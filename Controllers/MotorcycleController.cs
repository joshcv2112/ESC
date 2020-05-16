using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MotoInventory.Models;

namespace MotoInventory.Controllers
{
    public class MotorcycleController : Controller
    {
        MotorcycleDAL motorcycleDAL = new MotorcycleDAL();

        [Authorize]
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

        public IActionResult Edit(string vinNumber)
        {
            if (vinNumber == null)
            {
                return NotFound();
            }
            MotorcycleInfo motorcycle = motorcycleDAL.GetMotorcycleByVIN(vinNumber);
            if (motorcycle == null)
            {
                return NotFound();
            }
            return View(motorcycle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string vinNumber, [Bind] MotorcycleInfo objMotorcycle)
        {
            if (vinNumber == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                motorcycleDAL.UpdateMotorcycle(objMotorcycle);
                return RedirectToAction("Index");
            }
            return View(motorcycleDAL);
        }

        [HttpGet]
        public IActionResult Details(string vinNumber)
        {
            if (vinNumber == null)
            {
                return NotFound();
            }
            MotorcycleInfo emp = motorcycleDAL.GetMotorcycleByVIN(vinNumber);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        public IActionResult Delete(string vinNumber)
        {
            if (vinNumber == null)
            {
                return NotFound();
            }
            MotorcycleInfo motorcycle = motorcycleDAL.GetMotorcycleByVIN(vinNumber);
            if (motorcycle == null)
            {
                return NotFound();
            }
            return View(motorcycle);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMotorcycle(string vinNumber)
        {
            motorcycleDAL.DeleteMotorcycle(vinNumber);
            return RedirectToAction("Index");
        }
    }
}