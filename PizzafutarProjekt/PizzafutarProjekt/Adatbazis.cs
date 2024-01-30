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

        public Adatbazis()
        {
            AdatbazisMegnyitasa();
        }


    }
}
