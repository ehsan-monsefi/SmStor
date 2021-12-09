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
    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(int page = 1, string category = "All", string q = "")
        {
            var data = productService.ProductSearch(q, category, page, 9);
            PageList<Product> pageList = new PageList<Product>(data.Item1, page, 9, data.Item2);
            ViewBag.category = category;
            ViewBag.q = q;
            return View(pageList);
        }
    }
}