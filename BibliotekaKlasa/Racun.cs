using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlasa
{
    public class Racun
    {
        public int IdRacun { get; set; }
        public decimal Cena { get; set; }
        public DateTime Datum { get; set; }
        public string Vreme { get; set; }

        public Racun()
        {
            IdRacun = 0;
            Cena = 0;
            Datum = new DateTime(2020, 1, 1, 0, 0, 0);
            Vreme = Datum.ToString("t");
        }

        public Racun(int a, decimal b, DateTime c, string d)
        {
            IdRacun = a;
            Cena = b;
            Datum = c;
            Vreme = d;
        }

        override public string ToString()
        {
            return IdRacun + " - " + Cena + " - " + Datum.ToString("dd.MM.yyyy") + " - " + Vreme;
        }
    }
}
