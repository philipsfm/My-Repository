using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekat.Models
{
    public class KontaktTelefon
    {
                //i.Oznaku tipa(Kancelarija, Službeni Mobilni itd.)
                //ii.Broj telefona
                //iii.Lokal

        public int Id { get; set; }
        public string TipKontaktTelefona { get; set; }
        public double BrKontaktTelefona { get; set; }
        public int Lokal { get; set; }

    }
}