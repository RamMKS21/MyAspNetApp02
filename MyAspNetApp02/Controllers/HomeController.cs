using Microsoft.AspNetCore.Mvc;

namespace MyAspNetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello CI/CD World!";
            return View();
        }
    }
}