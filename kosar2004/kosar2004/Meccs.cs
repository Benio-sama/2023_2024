using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    internal class Meccs
    {
        private string hazai;
        private string idegen;
        private int hazaip;
        private int idegenp;
        private string helyszin;
        private DateTime datum;

        public Meccs(string hazai, string idegen, int hazaip, int idegenp, string helyszin, DateTime datum)
        {
            this.hazai = hazai;
            this.idegen = idegen;
            this.hazaip = hazaip;
            this.idegenp = idegenp;
            this.helyszin = helyszin;
            this.datum = datum;
        }

        public string Hazai { get => hazai; set => hazai = value; }
        public string Idegen { get => idegen; set => idegen = value; }
        public int Hazaip { get => hazaip; set => hazaip = value; }
        public int Idegenp { get => idegenp; set => idegenp = value; }
        public string Helyszin { get => helyszin; set => helyszin = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public override string ToString()
        {
            return $"hazai: {this.hazai} (pontszama: {this.hazaip}), idegen: {this.idegen} (pontszama {this.idegenp}), idopont: {this.datum}, helyszin: {this.helyszin}";
        }
    }
}
