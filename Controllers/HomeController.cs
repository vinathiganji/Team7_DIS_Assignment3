using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Team7_DIS_Assignment3.Models;

namespace Team7_DIS_Assignment3.Controllers
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
            Response.Redirect("index.html");
            return View();
        }

       
        public ActionResult Tropical()
        {
            return View("Tropical");
        }
        public ActionResult Beach()
        {
            return View("Beach");
        }
        public ActionResult Mountain()
        {
            return View("Mountain");
        }
        public ActionResult Contact()
        {
            return View("Contact");
        }
        public ActionResult Aboutus()
        {
            return View("Aboutus");
        }
        public ActionResult Login()
        {
            return View("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
