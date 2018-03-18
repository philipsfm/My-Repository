using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class RadnoMestoViewModel
    {
        public IEnumerable<RadnoMesto> listaRadnoMesto { get; set; }
        public RadnoMesto RadnoMesto { get; set; }
    }
}