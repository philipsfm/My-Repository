using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vol3.Models;
using Vol3.ViewModels;
using System.Data.Entity;

namespace Vol3.Controllers
{
    public class MejlController : Controller
    {
        private ApplicationDbContext _contex;

        public MejlController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: Mejl
        public ViewResult Index()
        {
            var mejl = _contex.Mejl.Include(c=>c.TipMejla).ToList();

            return View(mejl);
        }

        //// GET: Mejl/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Mejl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mejl/Create
        [HttpPost]
        public ActionResult Create(Mejl mejl)
        {
            _contex.Mejl.Add(mejl);
            _contex.SaveChanges();

            return RedirectToAction("Index", "Mejl");
        }

        //// GET: Mejl/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Mejl/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Mejl/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Mejl/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
