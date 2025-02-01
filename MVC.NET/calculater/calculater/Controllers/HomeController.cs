using System;
using System.Web.Mvc;

namespace calculater.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            try
            {
                // Validate form values
                if (string.IsNullOrWhiteSpace(obj["txtnum1"]) || string.IsNullOrWhiteSpace(obj["txtnum2"]) || string.IsNullOrWhiteSpace(obj["operation"]))
                {
                    ViewBag.data = "Please provide both numbers and a valid operation.";
                    return View();
                }

                int num1 = Convert.ToInt32(obj["txtnum1"]);
                int num2 = Convert.ToInt32(obj["txtnum2"]);
                string operation = obj["operation"];

                string result = string.Empty;

                switch (operation)
                {
                    case "Add":
                        result = $"The sum is {num1 + num2}";
                        break;

                    case "Subtract":
                        result = $"The difference is {num1 - num2}";
                        break;

                    case "Multiply":
                        result = $"The product is {num1 * num2}";
                        break;

                    case "Divide":
                        if (num2 != 0)
                            result = $"The quotient is {num1 / num2}";
                        else
                            result = "Division by zero is not allowed.";
                        break;

                    default:
                        result = "Invalid operation selected.";
                        break;
                }

                ViewBag.data = result;
            }
            catch (FormatException ex)
            {
                ViewBag.data = "Error: Please enter valid numbers.";
            }
            catch (Exception ex)
            {
                ViewBag.data = "Error: " + ex.Message;
            }

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
