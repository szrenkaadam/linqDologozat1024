using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDologozat1024
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldakSzama { get; set; }
        public double TerfArany { get; set; }

        public Bolygo(string sor)
        {
            string[] v = sor.Split(";");
            Nev = v[0];
            HoldakSzama = int.Parse(v[1]);
            TerfArany = double.Parse(v[2]);
        }
    }
}
