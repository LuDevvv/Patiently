using Microsoft.AspNetCore.Mvc;

namespace Patiently.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
