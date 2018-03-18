using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class OpstinaViewModel
    {
        public IEnumerable<Opstina> listaOpstina { get; set; }
        public Opstina Opstina { get; set; }
    }
}