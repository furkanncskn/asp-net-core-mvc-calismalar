using Microsoft.AspNetCore.Mvc;

namespace _004_Helpers.Controllers
{
    public class UrlHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UrlHelperAction()
        {
            return View();
        }
    }
}