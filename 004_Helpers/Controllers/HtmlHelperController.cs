using Microsoft.AspNetCore.Mvc;

namespace _004_Helpers.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HtmlAction()
        {
            return View();
        }
    }
}