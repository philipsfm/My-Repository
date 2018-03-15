using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Projekat.ViewModels;
//using Projekat.Models;

namespace Projekat.Controllers
{
    public class OsobaController : Controller
    {
        private ApplicationDbContext _context;

        public OsobaController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult New()
        {
            var tipKontaktTelefona = _context.TipKontaktTelefona.ToList();
            var viewModel = new OsobaFormViewModel
            {
                TipKontaktTelefona = tipKontaktTelefona
            };
            return View("OsobaForm",viewModel);
        }
        [HttpPost]
        public ActionResult Save(Osoba osoba)
        {
            if(osoba.ID==0)
                _context.Osobe.Add(osoba);
            else
            {
                var osobaInDb = _context.Osobe.Include(c=>c.KontaktTelefon).Single(c => c.ID == osoba.ID);

                //Mapper.map(osoba, osobaInDb);

                osobaInDb.Ime = osoba.Ime;
                osobaInDb.Prezime = osoba.Prezime;
                osobaInDb.RadnoMesto = osoba.RadnoMesto;
                osobaInDb.KontaktTelefonID = osoba.KontaktTelefonID;
                

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Osoba");
        }
        // GET: Osoba
        public ViewResult Index()
        {
            var osoba = _context.Osobe.Include(c => c.KontaktTelefonID).ToList();

            return View(osoba);
        }
        public ActionResult Details(int id)
        {


            var osoba = _context.Osobe.Include(c=>c.KontaktTelefon).SingleOrDefault(c => c.ID == id);

            if (osoba == null)
                return HttpNotFound();

            return View(osoba);
        }
        public ActionResult Edit(int id)
        {
            var osoba = _context.Osobe.SingleOrDefault(c => c.ID == id);

            if (osoba == null)
                return HttpNotFound();

            var viewModel = new OsobaFormViewModel
            {
                Osoba = osoba,
                TipKontaktTelefona = _context.TipKontaktTelefona.ToList()

            };
            return View("OsobaForm", viewModel);
        }

    }
}