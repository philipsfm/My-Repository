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
    public class PreduzeceController : Controller
    {
        private ApplicationDbContext _contex;

        public PreduzeceController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: Preduzece
        public ActionResult Index()
        {
            var preduzece = _contex.Preduzece.Include(c => c.Adresa).Include(c=>c.Opstina).ToList();

            return View(preduzece);
        }

        //// GET: Preduzece/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Preduzece/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Preduzece/Create
        [HttpPost]
        public ActionResult Create(Preduzece preduzece)
        {
            _contex.Preduzece.Add(preduzece);
            _contex.SaveChanges();

            return RedirectToAction("Index", "Preduzece");
        }

        //// GET: Preduzece/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Preduzece/Edit/5
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

        //// GET: Preduzece/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Preduzece/Delete/5
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
