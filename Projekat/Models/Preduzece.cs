using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekat.Models
{
    public class Preduzece
    {
            //        1.	ID Preduzeća - podatak se ne unosi, već se automatski generiše prilikom pohranjivanja u bazu.
            //2.	Pun naziv preduzeća
            //3.	Adresa registracije preduzeća
            //4.	Opština
            //5.	Poštanski Broj
            //6.	Matični broj preduzeća
            //7.	PIB
            //8.	Broj računa preduzeća u platnom prometu
            //9.	Web stranica preduzeća

        public int ID { get; set; }
        public string ImePreduzeca { get; set; }
        public string AdresaPreduzeca { get; set; }
        public string OpstinaPreduzeca { get; set; }
        public double PostanskiBrPreduzeca { get; set; }
        public double MaticniBrPreduzeca { get; set; }
        public double PIB { get; set; }
        public double BrRacunaPreduzeca { get; set; }
        public string WebStranicaPreduzeca { get; set; }


    }
}