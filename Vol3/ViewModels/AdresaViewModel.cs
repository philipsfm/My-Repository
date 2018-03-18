using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class AdresaViewModel
    {
        public IEnumerable<Adresa> listaAdresa { get; set; }
        public Adresa Adresa { get; set; }
    }
}