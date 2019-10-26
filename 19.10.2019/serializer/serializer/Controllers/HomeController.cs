using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using serializer.Models;

namespace serializer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = WebRequest.Create("https://www.cbar.az/currencies/" +
                DateTime.Now.ToString("dd.MM.yyyy") + ".xml");
            var responseData = client.GetResponse();
            var result = responseData.GetResponseStream();
            var sr = new StreamReader(result);
                  
            var xr = new XmlSerializer(typeof(ValCurs));
            var valyutas = xr.Deserialize(sr) as ValCurs;

            sr.Close();
            return View("Index", "_Layout", valyutas);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}