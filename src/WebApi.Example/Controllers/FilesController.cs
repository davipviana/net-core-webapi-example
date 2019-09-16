using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using WebApi.Example.Domain.Entity;
using WebApi.Example.Helper;

namespace WebApi.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpGet]
        [Route("excel")]
        [Produces("application/vnd.ms-excel")]
        public IActionResult GetExcelFile()
        {
            var persons = new List<Person>();

            var helper = new ExcelHelper<Person>();

            var fs = new FileStream(".\\Assets\\template.xlsx", FileMode.Open);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);

            byte[] outputBuffer = helper.GenerateFile(persons, buffer, 1);
            
            fs.Dispose();
            return File(outputBuffer, "application/ms-excel", "teste.xlsx");
        }
    }
}