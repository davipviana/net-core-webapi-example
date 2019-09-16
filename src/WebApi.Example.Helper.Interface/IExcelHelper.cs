using System.Collections.Generic;

namespace WebApi.Example.Helper.Interface
{
    public interface IExcelHelper<T>
    {
        byte[] GenerateFile(IEnumerable<T> rowObjects, byte[] template, int rowOffset = 0);
    }
}
