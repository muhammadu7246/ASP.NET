using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Home()
        {
            ViewData["Var1"] = "Data comes from ViewData";
            ViewBag.Var2 = "Data comes from ViewBag";
            TempData["Var3"] = "Data comes from TempData";
            Session["Var4"] = "Data comes from Session";

            return View();
        }
        public ActionResult About()
        {
            TempData["var2"] = "Data comes from ViewBag";
            return View();
        }
        public ActionResult Contect()
        {
            return View();
        }
        
    }
}