using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class TipMejlovaViewModels
    {
        public IEnumerable<TipMejla> listaTipMejla { get; set; }
        public TipMejla TipMejla { get; set; }
    }
}