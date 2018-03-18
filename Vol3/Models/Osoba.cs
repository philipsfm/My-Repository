using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vol3.Models
{
    public class Osoba
    {
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public RadnoMesto RadnoMesto { get; set; }
        public int RadnoMestoID { get; set; }
        public KontaktTelefon KontaktTelefon { get; set; }
        public int KontaktTelefonID { get; set; }
        public Mejl Mejl { get; set; }
        public int MejlID { get; set; }
        public Preduzece Preduzece { get; set; }
        public int PreduzeceID { get; set; }
    }
}