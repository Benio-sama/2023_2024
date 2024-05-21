using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eutazas
{
    internal class Utas
    {
        private int megallo;
        private DateTime felszallas;
        private int azon;
        private string tipus;
        private DateTime? erv;
        private int? db;

        public Utas(int megallo, DateTime felszallas, int azon, string tipus, string utolso)
        {
            this.megallo = megallo;
            this.felszallas = felszallas;
            this.azon = azon;
            this.tipus = tipus;
            if (utolso.Length > 2)
            {
                DateTime help = DateTime.ParseExact(utolso, "yyyyMMdd", CultureInfo.InvariantCulture);
                this.erv = help;
                this.db = null;
            }
            else
            {
                this.db = int.Parse(utolso);
                this.erv = null;
            }
        }

        public int Megallo { get => megallo; set => megallo = value; }
        public DateTime Felszallas { get => felszallas; set => felszallas = value; }
        public int Azon { get => azon; set => azon = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public DateTime? Erv { get => erv; set => erv = value; }
        public int? Db { get => db; set => db = value; }

        public override string ToString()
        {
            if (this.erv == null)
            {
                return $"{this.megallo}. {this.felszallas} {this.azon} ({this.tipus}) {this.db}db";
            }
            else
            {
                return $"{this.megallo}. {this.felszallas} {this.azon} ({this.tipus}) {this.erv}";
            }
        }
    }
}
