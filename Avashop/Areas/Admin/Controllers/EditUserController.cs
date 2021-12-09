using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Contract;
using Domain.Entittes;
using Microsoft.AspNetCore.Mvc;

namespace Avashop.Areas.Admin.Controllers
{
    public class EditUserController : Controller
    {
        private readonly IUserRepository userRepository;
        public EditUserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult Edit(int Id)
        {
            var us = userRepository.GetUser(Id);
            return View(us);
        }
        public IActionResult EditU(User user)
        {
            userRepository.EditUser(user);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }
        [Area("Admin")]
        public IActionResult DeleteU(User user)
        {
            userRepository.DeleteUser(user);
            return RedirectToAction("Index", "User", new { area = "Admin"});
        }
    }
}