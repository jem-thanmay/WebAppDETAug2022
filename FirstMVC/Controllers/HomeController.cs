using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) //Dependancy Injection
        {
            _logger = logger;
        }

        public IActionResult Namaste(string name, string loc)
        {
            ViewBag.Username = name;
            ViewBag.Location = loc;
           
            return View();
        }

        public IActionResult Index()
        {
            return View();
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