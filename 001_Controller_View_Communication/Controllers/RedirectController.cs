using Microsoft.AspNetCore.Mvc;

namespace _001_Controller.View.Communication.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
