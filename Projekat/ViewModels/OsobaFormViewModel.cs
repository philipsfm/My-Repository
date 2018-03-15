using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekat.Models;

namespace Projekat.ViewModels
{
    public class OsobaFormViewModel
    {
        public IEnumerable<KontaktTelefon> TipKontaktTelefona { get; set; }
        public Osoba Osoba { get; set; }
    }
}