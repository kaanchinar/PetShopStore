using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
