using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Avashop.Models;
using Domain.Contract;
using Domain.Entittes;

namespace Avashop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            List<Product> products = productService.GetChippsetProduct();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
