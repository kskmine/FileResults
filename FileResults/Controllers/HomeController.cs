using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResults.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("Index Demo")]
        public ViewResult Index()
        {
            return View();
        }

        [NonAction]
        public string GetConnectionString()
        {
            return "The connection string";
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void Test()
        {
            //bu bir aksiyondur.
        }
    }
}