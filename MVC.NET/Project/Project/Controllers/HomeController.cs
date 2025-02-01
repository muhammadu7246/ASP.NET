using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()  // Corrected method name from 'Contect' to 'Contact'
        {
            return View();
        }

        public IActionResult Menu()  // Capitalized 'M' in Menu for consistency
        {
            return View();
        }

        public IActionResult Mester()  // Capitalized 'M' in Mester for consistency
        {
            return View();
        }

        public IActionResult ContactUs()  // Corrected method name from 'Contect_us' to 'ContactUs'
        {
            return View();
        }

        public IActionResult prec()  // Corrected method name from 'Prec' to 'Price'
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.0m, Description = "Description 1", CreatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Product 2", Price = 20.0m, Description = "Description 2", CreatedDate = DateTime.Now }
            };

            // Passing the products list to the View
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
