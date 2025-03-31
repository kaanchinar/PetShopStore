using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
