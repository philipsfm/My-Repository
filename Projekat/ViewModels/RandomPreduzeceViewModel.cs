using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekat.Models;

namespace Projekat.ViewModels
{
    public class RandomPreduzeceViewModel
    {
        public Preduzece Preduzece { get; set; }
        public List<Osoba> Osoba { get; set; }
    }
}