using Microsoft.AspNetCore.Mvc;

namespace PhoniaTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
