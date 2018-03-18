using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class TipKontaktaViewModel
    {
        public IEnumerable<TipKontakta> listaTipKontakta { get; set; }
        public TipKontakta TipKontakta { get; set; }
    }
}