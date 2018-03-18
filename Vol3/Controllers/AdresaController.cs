using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vol3.Models;
using Vol3.ViewModels;

namespace Vol3.Controllers
{
    public class AdresaController : Controller
    {
        private ApplicationDbContext _contex;

        public AdresaController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: Adresa
        public ActionResult Index()
        {
            var adresa = _contex.Adresa.ToList();

            return View(adresa);
        }

        //// GET: Adresa/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Adresa/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: Adresa/Create
        [HttpPost]
        public ActionResult Create(Adresa adresa)
        {
            _contex.Adresa.Add(adresa);
            _contex.SaveChanges();

            return RedirectToAction("Index", "Adresa");
        }

        //// GET: Adresa/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Adresa/Edit/5
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

        //// GET: Adresa/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Adresa/Delete/5
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
