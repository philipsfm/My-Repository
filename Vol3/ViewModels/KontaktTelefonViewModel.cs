using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class KontaktTelefonViewModel
    {
        //public IEnumerable<KontaktTelefon> listaKontaktTelefon { get; set; }
        public KontaktTelefon KontaktTelefon { get; set; }
        public IEnumerable<TipKontakta> TipKontakta { get; set; }
        
    }
}