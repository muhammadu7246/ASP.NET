using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index(FormCollection imd)
        {
            int num1 = Convert.ToInt32(imd["txtnum1"]);
            int num2 = Convert.ToInt32(imd["txtnum2"]);
            string operation = imd["operation"];
            string result = string.Empty;

            switch (operation)
            {
                case "Add":
                    result = $"result will be ${num1 + num2}";
                    break;
                case "Subtract":
                    result = $"result will be ${num1 + num2}";
                    break;
                case "Multiply":
                    result = $"result will be ${num1 + num2}";
                    break;
                case "Divide":
                    result = $"result will be ${num1 + num2}";
                    break;
                default:
                    result = "Chack Your Operator";
                    break;

            }
            ViewBag.data = result;
            return View();
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