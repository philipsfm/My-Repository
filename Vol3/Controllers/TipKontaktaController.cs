using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vol3.Models;
using Vol3.ViewModels;

namespace Vol3.Controllers
{
    public class TipKontaktaController : Controller
    {
        private ApplicationDbContext _contex;

        public TipKontaktaController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: TipKontakta
        public ActionResult Index()
        {
            var tipKontakta = _contex.TipKontakta.ToList();

            return View(tipKontakta);
        }

        // GET: TipKontakta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipKontakta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipKontakta/Create
        [HttpPost]
        public ActionResult Create(TipKontakta tipKontakta)
        {
            _contex.TipKontakta.Add(tipKontakta);
            _contex.SaveChanges();

            return RedirectToAction("Index", "TipKontakta");
        }

        //// GET: TipKontakta/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: TipKontakta/Edit/5
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

        //// GET: TipKontakta/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TipKontakta/Delete/5
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
