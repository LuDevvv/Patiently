using Microsoft.AspNetCore.Mvc;

namespace Patiently.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
