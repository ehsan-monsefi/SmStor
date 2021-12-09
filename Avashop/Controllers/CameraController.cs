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
    public class CameraController : Controller
    {
        private readonly ICameraService cameraService;
        public CameraController(ICameraService cameraService)
        {
            this.cameraService = cameraService;
        }
        public IActionResult Index(int page = 1, string category = "All", string q = "")
        {
            var data = cameraService.CameraSearch(q, category, page, 9);
            PageList<Camera> pageList = new PageList<Camera>(data.Item1, page, 9, data.Item2);
            ViewBag.category = category;
            ViewBag.q = q;
            return View(pageList);
        }
    }
}