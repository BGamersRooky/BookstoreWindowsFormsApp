using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotekaKlasa;
using Knjizara;

namespace KnjizaraGUI
{
    public partial class frmKnjizaraGUI : Form
    {
        //Klasa Baza za konektovanje na Bazu Podataka
        Baza baza = new Baza();

        //Klasa Knjizara se koristi za cuvanje podataka o knjizari (Liste Knjiga, Kategorija, Racuna)
        BibliotekaKlasa.Knjizara mojaKnjizara = new BibliotekaKlasa.Knjizara();

        //BindingSource Enkapsulira DataSource koji kasnije koristimo za prikaz Liste Knjiga i Racuna
        BindingSource ListaKnjigaBS = new BindingSource();
        BindingSource ListaKorpaBS = new BindingSource();

        public frmKnjizaraGUI()
        {
            InitializeComponent();

        }

        //Klikom na dugme dodajemo selektovani objekat iz ListeKnjiga u ListuKorpa radi daljeg upravljanja
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int x = int.Parse(numKolicina.Value.ToString());

            //Castujemo selektovani red iz lsbListaKnjiga kao novu knjigu u ListaRacun
            for(int i = 0; i < x; i++) {
                mojaKnjizara.ListaRacun.Add((Knjiga)lsbListaKnjiga.SelectedItem);
            }

            //Resetujemo BinsingSource Korpe kako bi refreshovali i mogli da vidimo nove knjige u lsbRacun
            ListaKorpaBS.ResetBindings(false);

            //Na dnu racuna menjamo tekst label-a kako bi nam prikazao ukupnu cenu dodatih knjiga
            lblRacun.Text = mojaKnjizara.IzracunajRacun().ToString() + " RSD";
        }
        private void radAutor_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Ucitavanje forme prilikom pokretanaja, postavljanje pocetnih funkcija
        private void Form1_Load(object sender, EventArgs e)
        {
            radNaziv.Checked = true;

            //Dodajemo Knjige i Kategorije iz baze podataka u njihove Liste
            DodajKategorijeIzBaze();
            DodajKnjigeIzBaze();

            //Prikazivanje Liste Knjiga u lsbListKnjiga
            ListaKnjigaBS.DataSource = mojaKnjizara.ListaKnjiga;

            lsbListaKnjiga.DataSource = ListaKnjigaBS;
            lsbListaKnjiga.DisplayMember = ToString();

            //Prikazivanje Liste Knjiga u lsbRacun
            ListaKorpaBS.DataSource = mojaKnjizara.ListaRacun;

            lsbRacun.DataSource = ListaKorpaBS;
            lsbRacun.DisplayMember = ToString();
        }

        //Uklanja knjigu sa selektovanim indeksom iz Liste Racuna pritiskom na dugme
        private void btnUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                mojaKnjizara.ListaRacun.RemoveAt(lsbRacun.SelectedIndex);
                ListaKorpaBS.ResetBindings(false);

                lblRacun.Text = mojaKnjizara.IzracunajRacun().ToString() + " RSD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nijedan proizvod nije odabran!");
            }
        }

        //Klikom na Dugme Kupi, pravimo novi racun i brisemo sve iz liste Racun kako bi bila spremna za novu kupovinu
        private void btnKupi_Click(object sender, EventArgs e)
        {
            DateTime datum = new DateTime();
            datum = DateTime.Now;

            try
            {
                //Mozemo pokrenuti funkciju samo ako ima Knjiga u listi racun kako ne bi pravili prazne racune
                if (mojaKnjizara.ListaRacun.Count > 0)
                {
                    //Otvaramo konekciju ka bazi podataka kako bi smo upisali novu vrednost
                    baza.otvoriKonekciju();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baza.Conn;

                    //Pravimo upit sa paramtrima kako bi smo dodali novi red u bazu podataka
                    cmd.CommandText = @"INSERT INTO Racun(cena, datum, vreme) VALUES(@cena, @datum, @vreme)";
                    cmd.Parameters.AddWithValue("cena", mojaKnjizara.IzracunajRacun());
                    cmd.Parameters.AddWithValue("datum", datum);
                    cmd.Parameters.AddWithValue("vreme", datum.ToString("HH:mm"));

                    //Pokrecemo upit i vraca nam povratnu poruku koji potvrdjuje da li je upit izvrsen uspesno ili ne
                    int racun = cmd.ExecuteNonQuery();
                    if (racun > 0)
                    {
                        MessageBox.Show("Kupovina uspesna. Racun sacuvan!");
                    }
                    else
                    {
                        MessageBox.Show("Kupovina nije uspela...");
                    }

                    //Brisemo sve iz ListaRacun kako bi smo mogli da zapocnemo novu kupovinu sa novim Knjigama
                    mojaKnjizara.ListaRacun.Clear();

                    //Resetujemo vrednosti label-a racun i resetujemo Binding Soruce kako bi prikazali nove informacije
                    lblRacun.Text = mojaKnjizara.IzracunajRacun().ToString() + " RSD";
                    ListaKorpaBS.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Vasa korpa je prazna!");
                }
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

        //Otvara novu formu u kojoj mozemo da pregledamo listu racuna
        private void btnPregledRacuna_Click(object sender, EventArgs e)
        {
            ListaRacuna f2 = new ListaRacuna();
            f2.ShowDialog();
        }

        //Dodavanje nove knjige u Bazu podataka na osnovu unetih parametara
        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                //Otvaramo konekciju ka pazi i pravimo novi upit
                baza.otvoriKonekciju();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baza.Conn;

                //Knjigu mozemo dodati samo ako je odabrana neka od kategorija
                if (cmbDodajKategorija.SelectedIndex > 0)
                {
                    //Pravimo upit sa parametrima iz TextBox-ova i ComboBox-a
                    cmd.CommandText = @"INSERT INTO Knjiga(Naziv, Autor, Cena, Popust, idKategorija) VALUES(@Naziv, @Autor, @Cena, @Popust, @idKategorija)";
                    cmd.Parameters.AddWithValue("Naziv", txtDodajNaziv.Text);
                    cmd.Parameters.AddWithValue("Autor", txtDodajAutor.Text);
                    cmd.Parameters.AddWithValue("Cena", decimal.Parse(txtDodajCena.Text));
                    cmd.Parameters.AddWithValue("Popust", int.Parse(txtDodajPopust.Text));
                    cmd.Parameters.AddWithValue("idKategorija", int.Parse(cmbDodajKategorija.SelectedIndex.ToString()));

                    //Pokrecemo upit i saljemo povratnu poruku
                    int dodato = cmd.ExecuteNonQuery();
                    if (dodato > 0)
                    {
                        MessageBox.Show("Knjiga uspesno dodata!");

                        //Praznimo sva polja za upis radi dodavanja sledece knjige
                        txtDodajPopust.Text = "";
                        txtDodajNaziv.Text = "";
                        txtDodajCena.Text = "";
                        txtDodajAutor.Text = "";
                        cmbDodajKategorija.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Niste uspeli da dodate knjigu");
                    }
                }
                else
                {
                    MessageBox.Show("Molimo Vas da odaberete neku kategoriju!\n(Ne mozete odabrati defaultnu kategoriju \"Kategorija\")");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste uspeli da dodate knjigu, proverite da li ste lepo uneli sve podatke. Poruka o gresci:\n" + ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }

            //Posto je knjiga dodata, pokrecemo funkciju DodajKnjigeIzBaze kako bi se nova knjiga dodala u Listu Knjiga
            DodajKnjigeIzBaze();
        }

        //Dodavanje Podataka iz Baze Podataka u Listu Knjiga
        public void DodajKnjigeIzBaze()
        {
            try
            {
                //Proveravamo da li je odabrana neka kategorija ili je odabrana Defaultna Kategorija "Kategorija"
                //Ukoliko je odabrana Defaultna Kategorija prikazuje knjige iz svih kategorija, u suprotnom samo trazenu kategoriju
                if (cmbKategorija.SelectedIndex == 0)
                {
                    //Ukoliko je psotojala vec lista knjiga Prvo je brisemo kako bi mogli nove vrednosti da prikazemo
                    mojaKnjizara.ListaKnjiga.Clear();

                    baza.otvoriKonekciju();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baza.Conn;

                    //Pise upit za pretragu na osnobu Radio Buttona koji bira da li trazimo Naziv ili Autora knjige
                    //kao i TextBoxa u kojem pisemo naziv. Pretraga gleda da li se rec sadrzi u imenu i prikazuje sve objekte koji sadrze trazeni tekst
                    if (radNaziv.Checked)
                    {
                        cmd.CommandText = "SELECT * FROM Knjiga WHERE Naziv LIKE '%' + @vrednost + '%' ORDER BY IdKategorija, Autor";
                        cmd.Parameters.AddWithValue("vrednost", txtSearch.Text);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Knjiga WHERE Autor LIKE '%' + @vrednost + '%' ORDER BY IdKategorija, Autor";
                        cmd.Parameters.AddWithValue("vrednost", txtSearch.Text);
                    }

                    //Posto je upit napravljen pravimo SqlDataReader i upiusujemo sve dobijene redove iz upita kao objekte u listu Knjizara.ListaKnjiga
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Knjiga a = new Knjiga();
                        a.IdKnjiga = int.Parse(reader["IdKnjiga"].ToString());
                        a.Naziv = reader["Naziv"].ToString();
                        if(a.Naziv == "")
                        {
                            a.Naziv = "Nepoznat Naziv";
                        }
                        a.Autor = reader["Autor"].ToString();
                        if(a.Autor == "")
                        {
                            a.Autor = "Nepoznat Autor";
                        }
                        a.Cena = decimal.Parse(reader["Cena"].ToString());
                        a.Popust = int.Parse(reader["Popust"].ToString());
                        a.IdKategorija = int.Parse(reader["IdKategorija"].ToString());
                        a.KategorijaNaziv = mojaKnjizara.ListaKategorija[a.IdKategorija].Naziv;

                        mojaKnjizara.ListaKnjiga.Add(a);
                    }

                    //Resetujemo BindingSourse kako bi se ListBox Refreshovao i prikazao nove vrednosti
                    ListaKnjigaBS.ResetBindings(false);
                }

                // Ista procedura i za slucajeve kada imamo odabranu Kategoriju, jedina razlika je sto u upitu trazimo i IdKategorije u odnosu na ComboBox Kategorija
                else if(cmbKategorija.SelectedIndex > 0)
                {
                    mojaKnjizara.ListaKnjiga.Clear();

                    baza.otvoriKonekciju();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baza.Conn;

                    if (radNaziv.Checked)
                    {
                        cmd.CommandText = "SELECT * FROM Knjiga WHERE Naziv LIKE '%' + @vrednost + '%' AND IdKategorija = @IdKategorijaP ORDER BY IdKategorija, Autor";
                        cmd.Parameters.AddWithValue("vrednost", txtSearch.Text);
                        cmd.Parameters.AddWithValue("IdKategorijaP", cmbKategorija.SelectedValue);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Knjiga WHERE Autor LIKE '%' + @vrednost + '%' AND IdKategorija = @IdKategorijaP ORDER BY IdKategorija, Autor";
                        cmd.Parameters.AddWithValue("vrednost", txtSearch.Text);
                        cmd.Parameters.AddWithValue("IdKategorijaP", cmbKategorija.SelectedValue);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Knjiga a = new Knjiga();
                        a.IdKnjiga = int.Parse(reader["IdKnjiga"].ToString());
                        a.Naziv = reader["Naziv"].ToString();
                        a.Autor = reader["Autor"].ToString();
                        a.Cena = decimal.Parse(reader["Cena"].ToString());
                        a.Popust = int.Parse(reader["Popust"].ToString());
                        a.IdKategorija = int.Parse(reader["IdKategorija"].ToString());
                        a.KategorijaNaziv = mojaKnjizara.ListaKategorija[a.IdKategorija].Naziv;

                        mojaKnjizara.ListaKnjiga.Add(a);
                    }

                    ListaKnjigaBS.ResetBindings(false);
                }
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

        //Dodavanje Podataka iz Baze Podataka u Listu Kategorija i Dodaj Knjigu Kategorije
        public void DodajKategorijeIzBaze()
        {
            try
            {
                //Otvaramo vezu sa bazom podataka
                baza.otvoriKonekciju();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baza.Conn;

                //Trazimo sve Kategorije iz baze podataka
                cmd.CommandText = "SELECT * FROM Kategorija";
                SqlDataReader reader = cmd.ExecuteReader();
                
                //Pre upisa kategorija iz baze pravimo novu Defaultnu Kategoriju sa konstruktorom bez argumenata, 
                //ova kategorija bice koriscena da se prikazu sve kategorije umesto zasebnih kategorija
                mojaKnjizara.ListaKategorija.Add(new Kategorija());

                //Dodajemo kategorije iz baze podataka u listu Kategorija
                while (reader.Read())
                {
                    Kategorija kat = new Kategorija();
                    kat.IdKategorija = int.Parse(reader["IdKategorija"].ToString());
                    kat.Naziv = reader["Naziv"].ToString();

                    mojaKnjizara.ListaKategorija.Add(kat);
                }

                //Podesavamo parametre Combo Boxa za pretragu kategorija kao i dodavanje novih knjiga kako bi podaci prikazani bili povezani sa objektima iz liste
                cmbKategorija.DataSource = mojaKnjizara.ListaKategorija;
                cmbKategorija.DisplayMember = "Naziv";
                cmbKategorija.ValueMember = "IdKategorija";

                cmbDodajKategorija.DataSource = mojaKnjizara.ListaKategorija;
                cmbDodajKategorija.DisplayMember = "Naziv";
                cmbDodajKategorija.ValueMember = "IdKategorija";
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
        
        //Ponovo pokrece funkciju DodajKnjigeIzBaze() kada god se promeni neki od parametara za pretragu kako bi se lista ponovo ispisala
        private void RefreshListuKnjiga(object sender, EventArgs e)
        {
            baza.zatvoriKonekciju();
            DodajKnjigeIzBaze();
        }
    }
}
