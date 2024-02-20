using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzafutarProjekt
{
    internal class Adatbazis
    {
        private Dictionary<int, Pizza> pizzak = new Dictionary<int, Pizza>();
        private Dictionary<int, Cim> cimek = new Dictionary<int, Cim>();
        private List<Rendeles> rendelesek = new List<Rendeles>();
        MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();

        internal Dictionary<int, Pizza> Pizzak { get => pizzak; set => pizzak = value; }
        internal Dictionary<int, Cim> Cimek { get => cimek; set => cimek = value; }
        internal List<Rendeles> Rendelesek { get => rendelesek; set => rendelesek = value; }

        public Adatbazis()
        {
            AdatbazisMegnyitasa();
            CimBeolvasas();
            PizzakHozzaadasa();
            RendelesFelvetel();
        }

        private void CimBeolvasas()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conn.ConnectionString);
                connection.Open();
                string lekerdezes = "SELECT * FROM cim";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = lekerdezes;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        string cim = reader.GetString("utca");
                        string hazszam = reader.GetString("haz");
                        Cim c = new Cim(nev, cim, hazszam);
                        cimek.Add(id, c);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void PizzakHozzaadasa()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conn.ConnectionString);
                connection.Open();
                string lekerdezes = "SELECT * FROM pizza";
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = lekerdezes;
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        int meret = reader.GetInt32("meret");
                        int ar = reader.GetInt32("ar");
                        Pizza obj = new Pizza(nev, meret, ar);
                        pizzak.Add(id, obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AdatbazisMegnyitasa()
        {
            conn = new MySqlConnectionStringBuilder();
            conn.Server = "localhost";
            conn.Port = 3306;
            conn.Database = "pizzafutar";
            conn.UserID = "root";
            conn.Password = "";
        }

        private void RendelesFelvetel()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conn.ConnectionString);
                connection.Open();
                string lekerdezes = "SELECT * FROM rendeles";
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = lekerdezes;
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int pizzaId = reader.GetInt32("pizzaid");
                        int cimId = reader.GetInt32("cimid");
                        int db = reader.GetInt32("darab");
                        TimeSpan t = reader.GetTimeSpan("szallitas");
                        Pizza p = pizzak[pizzaId];
                        Cim c = cimek[cimId];
                        Rendeles r = new Rendeles(p, c, db, t);
                        rendelesek.Add(r);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
