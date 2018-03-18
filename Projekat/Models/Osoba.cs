using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Osoba
    {
        public int ID{ get; set; }
        [Required]
        [StringLength(255)]
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }
        public KontaktTelefon KontaktTelefon { get; set; }
        [Display(Name ="Tip Kontakt Telefona")]

        public byte KontaktTelefonID { get; set; }
        public string TipMejlAdrese { get; set; }
        public string MejlAdresa { get; set; }

    }
}