using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResults.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public FileResult Index()
        {
            // return File("~/Content/test.docx","aplication/msword");
            //  return File("~/Content/test.docx", "aplication/msword","aplication/test.docx");
           // return File("~/Content/test.txt", "txt/plain");
          //  return File("~/Content/test.txt", "txt/plain","test.txt");

            return new FilePathResult("~/Content/test.txt", "txt/plain")
            { FileDownloadName = "test.txt" };
        }

        public FileResult Index2()
        {
            byte[] Bytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/test.txt"));
            return File(Bytes,"text/plain", "test.txt");
        }

        public FileResult Index3()
        {
            //var fileStream = new System.IO.FileStream(Server.MapPath("~/Content/test.txt");
            // return File(fileStream, "test.txt");
           return File("text/plain", "test.txt");
        }
    }
}