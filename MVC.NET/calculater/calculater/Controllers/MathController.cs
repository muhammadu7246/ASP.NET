using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculater.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            return View();
        }
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


    }
}