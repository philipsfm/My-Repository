using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vol3.Models;
using Vol3.ViewModels;

namespace Vol3.Controllers
{
    public class TipMejlaController : Controller
    {
        private ApplicationDbContext _contex;
        
        public TipMejlaController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }
        public ActionResult Test()
        {
            var tipMejla = new TipMejla() {TipMejlaID=1, Opis = "Poslovni" };
            return View(tipMejla);
        }
        
        public ActionResult Index()
        {
            var tipMejla = _contex.TipMejla.ToList();

            return View(tipMejla);
        }

        //// GET: TipMejla/Details/5
        public ActionResult Details(int id)
        {
            var tipMejla = _contex.TipMejla.SingleOrDefault(c => c.TipMejlaID == id);
            if (tipMejla == null)
                return HttpNotFound();

            return View(tipMejla);
        }

        // GET: TipMejla/Create
        //[HttpPost]
        public ActionResult Create()
        {
            var listaTipMejla = _contex.TipMejla.ToList();
            var viewModel = new TipMejlovaViewModels
            {
                listaTipMejla = listaTipMejla
            };

            return View(viewModel);
        }

        //POST: TipMejla/Create
        [HttpPost]
        public ActionResult Create(TipMejla tipMejla)
        {
            _contex.TipMejla.Add(tipMejla);
            _contex.SaveChanges();

            return RedirectToAction("Index", "TipMejla");
        }

        //// GET: TipMejla/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: TipMejla/Edit/5
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

        //// GET: TipMejla/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TipMejla/Delete/5
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
