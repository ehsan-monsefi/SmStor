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
    public class CellphoneController : Controller
    {
        private readonly ICellphoneService cellphoneService;
        public CellphoneController(ICellphoneService cellphoneService)
        {
            this.cellphoneService = cellphoneService;
        }
        public IActionResult Index(int page = 1, string category = "All", string q = "")
        {
            var data = cellphoneService.CellphoneSearch(q, category, page, 9);
            PageList<Cellphone> pageList = new PageList<Cellphone>(data.Item1, page, 9, data.Item2);
            ViewBag.category = category;
            ViewBag.q = q;
            return View(pageList);
        }
    }
}