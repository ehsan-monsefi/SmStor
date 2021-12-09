using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ApplicationService;
using Domain.Contract;
using Domain.Entittes;
using Microsoft.AspNetCore.Mvc;

namespace Avashop.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            List<User> q = userRepository.GetUsers();
            return View(q);
        }
    }
}