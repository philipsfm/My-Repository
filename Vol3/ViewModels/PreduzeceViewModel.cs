using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol3.Models;

namespace Vol3.ViewModels
{
    public class PreduzeceViewModel
    {
        public Preduzece Preduzece { get; set; }
        public IEnumerable<Adresa> Adresa { get; set; }
        public IEnumerable<Opstina> Opstina { get; set; }
    }
}