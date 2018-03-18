using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vol3.Models
{
    public class Preduzece
    {
        public int PreduzeceID { get; set; }
        public string Naziv { get; set; }
        public double MaticniBroj { get; set; }
        public double PIB { get; set; }
        public double BrojRacuna { get; set; }
        public string WebStranica { get; set; }
        //public  image FotografijaPecata { get; set; } Ne znam jos koji je tip podatka.
        public string Beleska { get; set; }
        public Adresa Adresa { get; set; }
        public int AdresaID { get; set; }
        public Opstina Opstina { get; set; }
        public int OpstinaID { get; set; }
    }
}