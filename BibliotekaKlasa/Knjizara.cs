using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlasa
{
    public class Knjizara
    {
        public List<Knjiga> ListaKnjiga { get; set; }
        public List<Knjiga> ListaRacun { get; set; }
        public List<Kategorija> ListaKategorija { get; set; }
        public List<Racun> ListaKupovina { get; set; }
        public Knjizara()
        {
            ListaKnjiga = new List<Knjiga>();
            ListaRacun = new List<Knjiga>();
            ListaKategorija = new List<Kategorija>();
            ListaKupovina = new List<Racun>();
        }

        public decimal IzracunajRacun()
        {
            decimal racun = 0;
            foreach (Knjiga k in ListaRacun)
            {
                racun += k.Cena;
            }
            return racun;
        }
    }
}
