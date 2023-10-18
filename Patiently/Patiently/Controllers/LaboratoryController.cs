using Microsoft.AspNetCore.Mvc;

namespace Patientlys.Controllers
{
    public class LaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
