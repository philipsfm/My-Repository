using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vol3.Models
{
    public class KontaktTelefon
    {
        public int KontaktTelefonID { get; set; }
        public double Broj { get; set; }
        public int Lokal { get; set; }
        public TipKontakta TipKontakta { get; set; }
        public int TipKontaktaID { get; set; }
    }
}