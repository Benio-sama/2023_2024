using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek_adatbazissal
{
    internal class Adatbazis
    {
        private List<Versenyzo> versenyzo;
        MySqlConnectionStringBuilder con;
        public Adatbazis()
        {
            versenyzo = new List<Versenyzo>();
            con = new MySqlConnectionStringBuilder();
            con.Server = "localhost";
            con.Port = 3306;
            con.Database = "balkezesek";
            con.UserID = "root";
            con.Password = "";
            AdatokListazasa();
        }
        private void AdatokListazasa()
        {
            using (MySqlConnection connection = new MySqlConnection(con.ConnectionString))
            {
                connection.Open();
                string lekerdezes = "SELECT * FROM balkezesek";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = lekerdezes;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nev = reader.GetString("nev");
                        string elso = reader.GetString("elso");
                        string utolso = reader.GetString("utolso");
                        int suly = reader.GetInt32("suly");
                        int magassag = reader.GetInt32("magassag");
                        versenyzo.Add(new Versenyzo(nev, DateTime.Parse(elso), DateTime.Parse(utolso), suly, magassag));
                    }
                }
            }
            foreach (var item in versenyzo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
