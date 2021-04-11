using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlasa
{
    public class Kategorija
    {
        public int IdKategorija { get; set; }
        public string Naziv { get; set; }

        public Kategorija()
        {
            Naziv = "Kategorija";
        }

        public Kategorija(int a, string b)
        {
            IdKategorija = a;
            Naziv = b;
        }
    }
}
