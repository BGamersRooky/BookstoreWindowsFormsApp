using BibliotekaKlasa;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Knjizara
{
    public partial class ListaRacuna : Form
    {
        //Klasa Baza za konektovanje na Bazu Podataka
        Baza baza = new Baza();

        //Klasa Knjizara se koristi za cuvanje podataka o knjizari (Liste Knjiga, Kategorija, Racuna)
        BibliotekaKlasa.Knjizara mojaKnjizara = new BibliotekaKlasa.Knjizara();

        //BindingSource Enkapsulira DataSource koji kasnije koristimo za prikaz Liste Racuna
        BindingSource ListaRacunaBS = new BindingSource();
        public ListaRacuna()
        {
            InitializeComponent();
        }

        //Ucitavanje forme prilikom pokretanaja, postavljanje pocetnih funkcija
        private void frmDodajKnjigu_Load(object sender, EventArgs e)
        {
            //Krajnji datum postavljamo na danasnji dan, ovo je takodje i njegov maksimalni datum
            //Pocetni datum i njegov maksimalni datum stavimo na dan pre odabranog krajnjeg datuma 
            dateKraj.MaxDate = DateTime.Now;
            dateKraj.Value = dateKraj.MaxDate;
            datePocetak.MaxDate = dateKraj.Value.AddDays(-1);
            datePocetak.Value = datePocetak.MaxDate;

            //Dodaje Racune iz Baze Podataka u ListaKupovina
            DodajRacuneIzBaze();

            //Prikazivanje Racune iz ListaKupovina u lsbListaRacuna
            ListaRacunaBS.DataSource = mojaKnjizara.ListaKupovina;
            lsbListaRacuna.DataSource = ListaRacunaBS;
            lsbListaRacuna.DisplayMember = ToString();
        }

        //Dodaje Racune iz Baze Podataka u ListaKupovina
        private void DodajRacuneIzBaze()
        {
            try
            {
                //Ukoliko imamo neke stare podatke u listi prvo ih brisemo
                mojaKnjizara.ListaKupovina.Clear();

                //Otvaramo konekciju ka bazi podataka i kreiramo upit
                baza.otvoriKonekciju();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baza.Conn;

                //U upitu zelimo da nam vrati racune koji su izmedju dva odabrana datuma u poljima forme
                cmd.CommandText = "SELECT * FROM Racun WHERE datum BETWEEN @dat_poc AND @dat_kraj";
                cmd.Parameters.AddWithValue("dat_poc", datePocetak.Value);
                cmd.Parameters.AddWithValue("dat_kraj", dateKraj.Value);

                //Pokrecemo upit i dodajemo dobijene redove kao objekte u Listu Kupovina
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.IdRacun = int.Parse(reader["IdRacun"].ToString());
                    r.Cena = decimal.Parse(reader["cena"].ToString());
                    r.Datum = DateTime.Parse(reader["datum"].ToString());
                    r.Vreme = reader["vreme"].ToString();

                    mojaKnjizara.ListaKupovina.Add(r);
                }

                //Resetujemo Binding Source kako bi se racuni prikazali u lsbListaRacuna
                ListaRacunaBS.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
        }

        //Promenom vrednosti Datuma na formi ponovo pokrecemo Dodavanje Racuna kako bi se prikazali racuni za novi vremenski period
        private void RefreshujListu(object sender, EventArgs e)
        {
            //Stavlja maksimalnu vrednos pocetnog datuma da bude dan manje od odabrane vrednosti krajnjeg datuma
            datePocetak.MaxDate = dateKraj.Value.AddDays(-1);

            DodajRacuneIzBaze();
        }
    }
}
