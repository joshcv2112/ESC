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

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    MotorcycleInfo emp = motorcycleDAL.GetMotorcycleByVIN(id);
        //    if (emp == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(emp);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int? id, [Bind] MotorcycleInfo objEmp)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        motorcycleDAL.UpdateMotorcycle(objEmp);
        //        return RedirectToAction("Index");
        //    }
        //    return View(motorcycleDAL);
        //}

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

        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    MotorcycleInfo emp = motorcycleDAL.GetMotorcycleByVIN(id);
        //    if (emp == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(emp);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteEmp(int? id)
        //{
        //    motorcycleDAL.DeleteMotorcycle(id);
        //    return RedirectToAction("Index");
        //}
    }
}