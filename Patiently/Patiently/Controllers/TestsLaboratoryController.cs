using Microsoft.AspNetCore.Mvc;

namespace Patiently.Controllers
{
    public class TestsLaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
