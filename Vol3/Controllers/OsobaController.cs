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
    public class OsobaController : Controller
    {
        private ApplicationDbContext _contex;

        public OsobaController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: Osoba
        public ActionResult Index()
        {
            var osoba = _contex.Osoba.Include(c => c.RadnoMesto).Include(c => c.KontaktTelefon).Include(c => c.Mejl).Include(c => c.Preduzece).ToList();

            return View(osoba);
        }

        //// GET: Osoba/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Osoba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Osoba/Create
        [HttpPost]
        public ActionResult Create(Osoba osoba)
        {
            _contex.Osoba.Add(osoba);
            _contex.SaveChanges();

            return RedirectToAction("Index", "Osoba");
        }

        //// GET: Osoba/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Osoba/Edit/5
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

        //// GET: Osoba/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Osoba/Delete/5
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
