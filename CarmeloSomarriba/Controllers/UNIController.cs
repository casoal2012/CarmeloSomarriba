using Microsoft.AspNetCore.Mvc;

namespace CarmeloSomarriba.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View("posgrado");
        }
    }
}
