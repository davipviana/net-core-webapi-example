using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebApi.Example.Helper.Interface;

namespace WebApi.Example.Helper
{
    public class ExcelHelper<T> : IExcelHelper<T>
    {
        #region IExcelHelper methods
        public byte[] GenerateFile(IEnumerable<T> rowObjects, byte[] template, int rowOffset = 0)
        {
            var memStream = new MemoryStream();
            memStream.Write(template, 0, template.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            
            using (var package = new ExcelPackage(memStream))
            {
                var worksheet = package.Workbook.Worksheets.First();

                for (var i = 0; i < rowObjects.Count(); i++)
                {
                    var rowObject = rowObjects.ElementAt(i);

                    var properties = rowObject.GetType().GetProperties();
                    for (var j = 0; j < properties.Count(); j++)
                    {
                        worksheet.Cells[i + 1 + rowOffset, j + 1].Value = properties[j].GetValue(rowObject).ToString();
                    }
                }
                memStream.Dispose();
                return package.GetAsByteArray();
            }
        }
        #endregion
    }
}
