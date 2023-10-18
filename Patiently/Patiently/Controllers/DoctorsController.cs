using Microsoft.AspNetCore.Mvc;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.Doctors;

namespace Patiently.Controllers
{
    public class DoctorsController : Controller
    {

        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _doctorService.GetAllViewModel());
        }


        public IActionResult Create()
        {
            return View("Create", new SaveDoctorViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveDoctorViewModel VM)
        {
            if (!ModelState.IsValid)
            {
                await _doctorService.Add(VM);
                return View("Create");
            }
            await _doctorService.Add(VM);
            return RedirectToRoute(new { controller = "Doctors", action = "Index" });
        }

        public async Task<IActionResult> Edit(int ID)
        {
            var VM = await _doctorService.GetByIdSaveViewModel(ID);
            if (VM.ID == 0)
            {
                return NotFound();
            }
            return View("Create", VM);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SaveDoctorViewModel VM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _doctorService.Update(VM);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Error saving changes...");
                    return View("Create", VM);
                }
            }

            return View("SaveMedico", VM);
        }


        public async Task<IActionResult> Delete(int ID)
        {
            var MedicoViewModel = await _doctorService.GetByIdSaveViewModel(ID);
            return View("Delete", MedicoViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int IDM)
        {
            try
            {
                await _doctorService.Delete(IDM);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }
        }
    }
}
