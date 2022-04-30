using _002_Tuple_ve_Model_Veri_Yollama.Models;
using Microsoft.AspNetCore.Mvc;

namespace _002_Tuple_ve_Model_Veri_Yollama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(DummyData.customerProducts);
        }
    }
}
