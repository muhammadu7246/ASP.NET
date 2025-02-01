using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculater.Controllers
{
    public class CalController : Controller
    {
        // GET: Cal
        public ActionResult Index()
        {
            return View();
        }
    }
}