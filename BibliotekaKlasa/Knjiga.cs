using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlasa
{
    public class Knjiga
    {
        public int IdKnjiga { get; set; }
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public decimal Cena { get; set; }
        public int Popust { get; set; }
        public int IdKategorija { get; set; }
        public string KategorijaNaziv { get; set; }

        public Knjiga()
        {
            Naziv = "Nema";
            Autor = "Nema";
            Cena = 0;
            Popust = 0;
            IdKategorija = 1;
        }
        public Knjiga(int a, string b, string c, decimal d, int e, int f)
        {
            IdKnjiga = a;
            Naziv = b;
            Autor = c;
            Cena = d;
            Popust = e;
            IdKategorija = f;
        }

        override public string ToString()
        {
            return + IdKnjiga + " - " + Naziv + " - " + Autor + " - " + Cena + " RSD - " + Popust + "% - " + KategorijaNaziv;
        }
    }
}
