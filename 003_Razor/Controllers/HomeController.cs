using Microsoft.AspNetCore.Mvc;

namespace _003_Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Operation = Operation.Division;

            return View();
        }
    }

    public enum Operation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}
