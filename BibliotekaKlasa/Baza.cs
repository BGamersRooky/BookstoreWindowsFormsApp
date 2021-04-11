using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlasa
{
    public class Baza
    {
        SqlConnection conn;

        public Baza()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\filip\Documents\Knjizara.mdf;Integrated Security=True;Connect Timeout=30";
        }
        public void otvoriKonekciju()
        {
            if(conn != null)
            {
                conn.Open();
            }
        }
        public void zatvoriKonekciju()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }
        public SqlConnection Conn { get => conn; set => conn = value; }
    }
}
