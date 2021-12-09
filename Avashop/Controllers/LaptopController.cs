using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avashop.Models;
using Domain.Contract;
using Domain.Entittes;
using Microsoft.AspNetCore.Mvc;

namespace Avashop.Controllers
{
    public class LaptopController : Controller
    {
        private readonly ILaptopService laptopService;
        public LaptopController(ILaptopService laptopService)
        {
            this.laptopService = laptopService;
        }
        public IActionResult Index(int page = 1, string category = "All", string q = "")
        {
            var data = laptopService.LaptopSearch(q, category, page, 9);
            PageList<Laptop> pageList = new PageList<Laptop>(data.Item1, page, 9, data.Item2);
            ViewBag.category = category;
            ViewBag.q = q;
            return View(pageList);
        }
    }
}