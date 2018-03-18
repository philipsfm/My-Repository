using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class OsobaViewModel
    {
        public Osoba Osoba { get; set; }
        public IEnumerable<RadnoMesto> RadnoMesto { get; set; }
        public IEnumerable<KontaktTelefon> KontaktTelefon { get; set; }
        public IEnumerable<Mejl> Mejl { get; set; }
        public Preduzece Preduzece { get; set; }
    }
}