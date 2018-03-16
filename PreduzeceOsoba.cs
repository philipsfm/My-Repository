using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vol2.Models
{
    public class PreduzeceOsoba
    {
        public Preduzece Preduzece { get; set; }
        public int PreduzeceID { get; set; }
        public Osoba Osoba { get; set; }
        public int OsobaID { get; set; }
    }
}