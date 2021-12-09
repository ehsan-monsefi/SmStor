using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ApplicationService;
using Domain.Contract;
using Domain.Entittes;
using Microsoft.AspNetCore.Mvc;

namespace Avashop.Controllers
{
    public class AdduserController : Controller
    {
        private readonly IUserRepository userRepository;
        public AdduserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if(user.City == null )
            {
                ModelState.AddModelError(nameof(user.City), "Please Insert City Name");
            }
            if (ModelState.IsValid)
            {
                
            }
            userRepository.AddUser(user);
            return RedirectToAction("Index", "Home");
        }
        
    }
}