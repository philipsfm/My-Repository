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
    public class KontaktTelefonController : Controller
    {
        private ApplicationDbContext _contex;

        public KontaktTelefonController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        // GET: KontaktTelefon
        public ViewResult Index()
        {
            var kontaktTelefon = _contex.KontaktTelefon.Include(c => c.TipKontakta).ToList();

            return View(kontaktTelefon);
        }

        //// GET: KontaktTelefon/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: KontaktTelefon/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: KontaktTelefon/Create
        [HttpPost]
        public ActionResult Create(KontaktTelefon kontaktTelefon)
        {
            _contex.KontaktTelefon.Add(kontaktTelefon);
            _contex.SaveChanges();

            return RedirectToAction("Index", "KontaktTelefon");
        }

        //// GET: KontaktTelefon/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: KontaktTelefon/Edit/5
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

        //// GET: KontaktTelefon/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: KontaktTelefon/Delete/5
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
