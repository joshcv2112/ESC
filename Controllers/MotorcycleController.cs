using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotoInventory.Models;

namespace MotoInventory.Controllers
{
    public class MotorcycleController : Controller
    {
        MotorcycleDAL motorcycleDAL = new MotorcycleDAL();

        public IActionResult Index()
        {
            List<MotorcycleInfo> motorcycleList = new List<MotorcycleInfo>();
            motorcycleList = motorcycleDAL.GetAllMotorcycle().ToList();
            return View(motorcycleList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] MotorcycleInfo objMotorcycle)
        {
            if (ModelState.IsValid)
            {
                motorcycleDAL.AddMotorcycle(objMotorcycle);
                return RedirectToAction("Index");
            }
            return View(objMotorcycle);
        }
    }
}