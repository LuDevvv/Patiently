//using Microsoft.AspNetCore.Mvc;
//using Pacientify.Core.Application.Services;
//using Pacientify.Core.Domain.Entities;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace PacientifyWeb.Controllers

//{
//    public class UsersController : Controller
//    {
//        private readonly UserService _userService;
//        public UserController(UserService userService)
//        {
//            _userService = userService;
//        }

//        public async Task<IActionResult> Index()
//        {
//            var users = await _userService.GetAllUsersAsync();
//            return View(users);
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(User user)
//        {
//            await _userService.CreateUserAsync(user);
//            return RedirectToAction("Index");
//        }

//        public async Task<IActionResult> Edit(int id)
//        {
//            var user = await _userService.GetUserByIdAsync(id);
//            return View(user);
//        }

//        [HttpPost]
//        public async Task<IActionResult> Edit(User user)
//        {
//            await _userService.UpdateUserAsync(user);
//            return RedirectToAction("Index");
//        }

//        public async Task<IActionResult> Delete(int id)
//        {
//            await _userService.DeleteUserAsync(id);
//            return RedirectToAction("Index");
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;

namespace Patiently.Controllers
{
    public class UsersController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
