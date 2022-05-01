using Microsoft.AspNetCore.Mvc;

namespace _004_Helpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}