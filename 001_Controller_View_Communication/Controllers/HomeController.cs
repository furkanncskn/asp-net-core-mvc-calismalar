using Microsoft.AspNetCore.Mvc;

namespace _001_Controller.View.Communication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Data"] = "Test-TempData";

            ViewData["Data"] = "Test-ViewData";

            ViewBag.Data = "Test-ViewBag";

            return RedirectToAction(
                    actionName: "Index", 
                    controllerName: "Redirect"
                );
        }
    }
}
