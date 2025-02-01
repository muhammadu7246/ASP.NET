using System;
using System.Web.Mvc;

namespace form.Controllers
{
    public class FormController : Controller
    {
        // GET: form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                ModelState.AddModelError("username", "User name is required");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                ModelState.AddModelError("email", "User email is required");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("password", "User password is required");
            }

            if (ModelState.IsValid)
            {
                // Set success and form data messages
                ViewData["SuccessMessage"] = "<script>alert('Thank you for submitting the form');</script>";
                ViewData["nameMessage"] = username;
                ViewData["emailMessage"] = email;
                ViewData["PassMessage"] = password;

                // Clear the model state after success
                ModelState.Clear();
            }

            return View();
        }
    }
}
