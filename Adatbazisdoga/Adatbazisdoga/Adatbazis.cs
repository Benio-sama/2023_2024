using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazisdoga
{
    internal class Adatbazis
    {
        private Dictionary<Album, int> albums = new Dictionary<Album, int>();
        private Dictionary<Toplista, int> toplistas = new Dictionary<Toplista, int>();
        MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();

        internal Dictionary<Album, int> Albums { get => albums; set => albums = value; }
        internal Dictionary<Toplista, int> Toplistas { get => toplistas; set => toplistas = value; }

        public Adatbazis() 
        {
            Megnyitas();
            AlbumBeolvasas();
            ToplistaBeolvasas();
        }

        private void Megnyitas()
        {
            conn = new MySqlConnectionStringBuilder();
            conn.Server = "localhost";
            conn.Port = 3306;
            conn.Database = "slagerlista";
            conn.UserID = "root";
            conn.Password = "";
        }

        private void AlbumBeolvasas()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conn.ConnectionString);
                connection.Open();
                string lekerdezes = "SELECT * FROM album";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = lekerdezes;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string eloado = reader.GetString("eloado");
                        string cim = reader.GetString("cim");
                        Album a = new Album(eloado, cim);
                        albums.Add(a, id);
                    }
                }
                /*foreach (var item in albums)
                {
                    Console.WriteLine(item);
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ToplistaBeolvasas()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conn.ConnectionString);
                connection.Open();
                string lekerdezes = "SELECT * FROM toplista";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = lekerdezes;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int albumid = reader.GetInt32("albumid");
                        int helyezes = reader.GetInt32("helyezes");
                        int platinadb;
                        if (reader["platinadb"] != DBNull.Value)
                        {
                            platinadb = reader.GetInt32("platinadb");
                        }
                        else
                        {
                            platinadb = 0;
                        }
                        int ev = reader.GetInt32("ev");
                        string kiado = reader.GetString("kiado");
                        Toplista t = new Toplista(helyezes, platinadb, ev, kiado);
                        toplistas.Add(t, albumid);
                    }
                }
                /*foreach (var item in toplistas)
                {
                    Console.WriteLine(item);
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Fekete()
        {
            foreach (var item in albums)
            {
                if (item.Key.Eloado.ToLower().Contains("fekete") || item.Key.Cim.ToLower().Contains("fekete"))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Statisztika()
        {
            Dictionary<string,int> stat = new Dictionary<string,int>();
            foreach (var item in toplistas)
            {
                string kulcs = item.Key.Kiado;
                if (!stat.ContainsKey(kulcs))
                {
                    stat.Add(kulcs, 0);
                }
                stat[kulcs]++;
            }
            foreach (var item in stat)
            {
                Console.WriteLine(item.Key + " - " + item.Value + " db");
            }
        }
        public void EloadoPlat()
        {
            //Adja  meg  lekérdezés  segítségével  azt  az  előadót,  aki  a  legtöbb  platinalemez-elismerést  kapta!
            Dictionary<string, int> stat = new Dictionary<string,int>();
            foreach (var item in albums)
            {
                string kulcs = item.Key.Eloado;
                int id = item.Value;
                int plat = 0;
                foreach (var item1 in toplistas)
                {
                    if (item1.Value == id)
                    {
                        plat += item1.Key.Platinadb;
                    }
                }
                if (stat.ContainsKey(kulcs))
                {
                    stat[kulcs] += plat;
                }
                else
                {
                    stat.Add(kulcs, plat);
                }

            }
            string nev = "asd";
            int max = 0;
            foreach (var item in stat)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    nev = item.Key;
                }
            }
            Console.WriteLine(nev + " - " + max);
        }
        public void NevCim()
        {
            foreach (var item in albums)
            {
                if (item.Key.Cim.ToLower().Contains(item.Key.Eloado.ToLower()))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void SzereplesDB()
        {
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in albums)
            {
                string kulcs = $"{item.Key.Eloado} - {item.Key.Cim}";
                int id = item.Value;
                int db = 0;
                foreach (var item1 in toplistas)
                {
                    if (item1.Value == id)
                    {
                        db ++;
                    }
                }
                if (stat.ContainsKey(kulcs))
                {
                    stat[kulcs] += db;
                }
                else
                {
                    stat.Add(kulcs, db);
                }
            }
            foreach (var item in stat)
            {
                if (item.Value > 2)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void PalyaBea()
        {
            Dictionary<string, string> stat = new Dictionary<string, string>();
            foreach (var item in albums)
            {
                if (item.Key.Eloado == "Palya Bea")
                {
                    foreach (var item1 in toplistas)
                    {
                        if (item.Value == item1.Value)
                        {
                            string val = item1.Key.Kiado;
                            foreach (var item2 in toplistas)
                            {
                                if (item2.Key.Kiado == val)
                                {
                                    foreach (var item3 in albums)
                                    {
                                        if (item2.Value == item3.Value)
                                        {
                                            string kulcs = item3.Key.Eloado;
                                            if (!stat.ContainsKey(kulcs))
                                            {
                                                stat.Add(kulcs, val);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var item in stat)
            {
                Console.WriteLine(item);
            }
        }
    }
}
