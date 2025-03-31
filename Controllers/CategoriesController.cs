using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cats()
        {
            return View();
        }
        public IActionResult Dogs()
        {
            return View();
        }
        public IActionResult Birds()
        {
            return View();
        }
        public IActionResult Other()
        {
            return View();
        }
    }
}
