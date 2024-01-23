using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data.MySqlClient;

namespace kosar2004
{
    internal class Feladatok
    {
        private List<Meccs> meccsek = new List<Meccs>();
        MySqlConnectionStringBuilder con = new MySqlConnectionStringBuilder();

        public Feladatok()
        {
            con.Server = "localhost";
            con.Port = 3306;
            con.Database = "eredmenyek";
            con.UserID = "root";
            con.Password = "";
        }

        internal List<Meccs> Meccsek { get => meccsek; set => meccsek = value; }

        public void Beolvasas()
        {
            using (MySqlConnection connection = new MySqlConnection(con.ConnectionString))
            {
                connection.Open();
                string lekerdezes = "SELECT * FROM eredmenyek";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = lekerdezes;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string hazai = reader.GetString("hazai");
                        string idegen = reader.GetString("idegen");
                        int hazaip = reader.GetInt32("hazai_pont");
                        int idegenp = reader.GetInt32("idegen_pont");
                        string helyszin = reader.GetString("helyszin");
                        DateTime datum = DateTime.Parse(reader.GetString("idopont"));
                        Meccs m = new Meccs(hazai, idegen, hazaip, idegenp, helyszin, datum);
                        meccsek.Add(m);
                    }
                }
            }
            /*foreach (var item in meccsek)
            {
                Console.WriteLine(item);
            }*/
        }
        public string HanyRM()
        {
            int db = 0;
            int db2 = 0;
            foreach (var item in meccsek)
            {
                if (item.Hazai == "Real Madrid")
                {
                    db++;
                }
                if (item.Idegen == "Real Madrid")
                {
                    db2++;
                }
            }
            return $"3. Feladat: Real Madrid: Hazai: {db}, Idegen: {db2}";
        }
        public string Dontetlen()
        {
            foreach (var item in meccsek)
            {
                if (item.Hazaip == item.Idegenp)
                {
                    return "4. feladat: Volt dontetlen? igen";
                }
            }
            return "4. feladat: Volt dontetlen? nem";
        }
        public string Barcelona()
        {
            foreach (var item in meccsek)
            {
                if (item.Hazai.Contains("Barcelona"))
                {
                    return $"5. feladat: barceloniai csapat neve: {item.Hazai}";
                }
                else if (item.Idegen.Contains("Barcelona"))
                {
                    return $"5. feladat: barceloniai csapat neve: {item.Idegen}";
                }
            }
            return "5. feladat: nincs barcelonai csapat";
        }
        public void Nov() 
        {
            foreach (var item in meccsek)
            {
                if (item.Datum.Year == 2004 && item.Datum.Month == 11 && item.Datum.Day == 21)
                {
                    Console.WriteLine($"\t{item.Hazai} - {item.Idegen} ({item.Hazaip}:{item.Idegenp})");
                }
            }
        }
        public void Stadion()
        {
            Dictionary<string,int> list = new Dictionary<string,int>();
            foreach (var item in meccsek)
            {
                string kulcs = item.Helyszin;
                if (!list.ContainsKey(kulcs))
                {
                    list.Add(kulcs, 0);
                }
                list[kulcs]++;
            }
            foreach (var item in list)
            {
                if (item.Value > 20)
                {
                    Console.WriteLine($"\t{item.Key}: {item.Value}");
                }
            }
        }
    }
}
