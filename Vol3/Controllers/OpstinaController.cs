using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vol3.Models;
using Vol3.ViewModels;

namespace Vol3.Controllers
{

    public class OpstinaController : Controller
    {
        private ApplicationDbContext _contex;

        public OpstinaController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: Opstina
        public ActionResult Index()
        {
            var adresa = _contex.Opstina.ToList();

            return View(adresa);
        }

        // GET: Opstina/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Opstina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opstina/Create
        [HttpPost]
        public ActionResult Create(Opstina opstina)
        {
            _contex.Opstina.Add(opstina);
            _contex.SaveChanges();

            return RedirectToAction("Index", "Opstina");
        }

        //// GET: Opstina/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Opstina/Edit/5
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

        //// GET: Opstina/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Opstina/Delete/5
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
