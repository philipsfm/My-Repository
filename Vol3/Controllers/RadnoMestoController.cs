using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vol3.Models;
using Vol3.ViewModels;

namespace Vol3.Controllers
{
    public class RadnoMestoController : Controller
    {
        private ApplicationDbContext _contex;

        public RadnoMestoController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        //GET: RadnoMesto
        public ActionResult Index()
        {
            var radnoMesto = _contex.RadnoMesto.ToList();

            return View(radnoMesto);
        }

        //// GET: RadnoMesto/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: RadnoMesto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RadnoMesto/Create
        [HttpPost]
        public ActionResult Create(RadnoMesto radnoMesto)
        {
            _contex.RadnoMesto.Add(radnoMesto);
            _contex.SaveChanges();

            return RedirectToAction("Index", "RadnoMesto");
        }

        //// GET: RadnoMesto/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: RadnoMesto/Edit/5
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

        //// GET: RadnoMesto/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RadnoMesto/Delete/5
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
