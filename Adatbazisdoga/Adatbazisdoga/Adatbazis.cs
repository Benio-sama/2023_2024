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
        private Dictionary<int, Album> albums = new Dictionary<int, Album>();
        private List<Album> albumok = new List<Album>();
        private Dictionary<int, Toplista> toplistas = new Dictionary<int, Toplista>();
        private List<Toplista> toplistak = new List<Toplista>();
        MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();

        internal Dictionary<int, Album> Albums { get => albums; set => albums = value; }
        internal Dictionary<int, Toplista> Toplistas { get => toplistas; set => toplistas = value; }

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
                        albums.Add(id, a);
                        albumok.Add(a);
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
                        toplistas.Add(albumid, t);
                        toplistak.Add(t);
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
            foreach (var item in albumok)
            {
                if (item.Eloado.ToLower().Contains("fekete") || item.Cim.ToLower().Contains("fekete"))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Statisztika()
        {
            Dictionary<string,int> stat = new Dictionary<string,int>();
            foreach (var item in toplistak)
            {
                string kulcs = item.Kiado;
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
            foreach (var item in toplistak)
            {
                string kulcs = item.Kiado;
                if (!stat.ContainsKey(kulcs))
                {
                    stat.Add(kulcs, 0);
                }
            }

        }
        public void NevCim()
        {
            foreach (var item in albumok)
            {
                if (item.Cim.ToLower().Contains(item.Eloado.ToLower()))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
