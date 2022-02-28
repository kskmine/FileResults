using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace FileResults.Controllers
{  // GET: Custom
    public class CustomResult : ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Write("CutomResult");
        }

        public ActionResult Index()
        {
            return new CustomResult();
        }
        public class Product
        {
            public string Name { get; set; }
            public int UnitPrice { get; set; }
        }
        public class XmlResult : ActionResult
        {
            private readonly object _data;
            public XmlResult(object data)
            {
                _data = data;
            }
            public override void ExecuteResult(ControllerContext context)
            {
                if (_data != null)
                {
                    var xs = new XmlSerializer(_data.GetType());
                    context.HttpContext.Response.ContentType = "application/xml";
                    xs.Serialize(context.HttpContext.Response.Output, _data);
                }
            }
        }
        public ActionResult Index2()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name="laptop",
                    UnitPrice=100
                },
                new Product
                {
                    Name="mouse",
                    UnitPrice=50
                }
            };
            return new XmlResult(products);
        }
    }
}