using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;


namespace Vol3.ViewModels
{
    public class MejlViewModel
    {
        //public IEnumerable<Mejl> listaMejl { get; set; }
        public Mejl Mejl { get; set; }
        public IEnumerable<TipMejla> TipMejla { get; set; }
        //public IEnumerable<KontaktTelefon> TipKontaktTelefona { get; set; }
    }
}