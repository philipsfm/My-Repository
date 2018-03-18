using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekat.Models;
using Projekat.Migrations;
using Projekat.ViewModels;
using System.Data.Entity;



namespace Projekat.Controllers
{
    public class PreduzeceController : Controller
    {
        private ApplicationDbContext _context;

        public PreduzeceController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Preduzece/Random
        public ActionResult Details(int id)
        {
            var osoba = _context.Preduzece.SingleOrDefault(c => c.ID == id);

            if (osoba == null)
                return HttpNotFound();

            return View(osoba);

        }
        public ViewResult Index()
        {
            var preduzece = _context.Preduzece.ToList();

            return View(preduzece);
        }
        public ViewResult New()
        {

            var viewModel = new PreduzeceFormViewModel
            {
               
            };

            return View("PreduzeceForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var preduzece = _context.Preduzece.SingleOrDefault(c => c.ID == id);

            if (preduzece == null)
                return HttpNotFound();

            var viewModel = new PreduzeceFormViewModel
            {
                Preduzece = preduzece
                 
            };

            return View("PreduzeceForm", viewModel);
        }
        public ActionResult Save(Preduzece preduzece)
        {
            if (preduzece.ID == 0)
            {
                _context.Preduzece.Add(preduzece);
            }
            else
            {
                var preduzeceInDb = _context.Preduzece.Single(m => m.ID == preduzece.ID);
                preduzeceInDb.ImePreduzeca = preduzece.ImePreduzeca;
                preduzeceInDb.AdresaPreduzeca = preduzece.AdresaPreduzeca;
                preduzeceInDb.OpstinaPreduzeca = preduzece.OpstinaPreduzeca;
                preduzeceInDb.PostanskiBrPreduzeca = preduzece.PostanskiBrPreduzeca;
                preduzeceInDb.MaticniBrPreduzeca = preduzece.MaticniBrPreduzeca;
                preduzeceInDb.PIB = preduzece.PIB;
                preduzeceInDb.BrRacunaPreduzeca = preduzece.BrRacunaPreduzeca;
                preduzeceInDb.WebStranicaPreduzeca = preduzece.WebStranicaPreduzeca;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Preduzece");
        }
    }
}