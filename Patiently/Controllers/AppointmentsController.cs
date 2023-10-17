using Microsoft.AspNetCore.Mvc;

namespace Patiently.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
