using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamitasok_BL
{
    public class Kor
    {
        //sugar property (tulajdonság), a set beállítja az értékét
        public double sugar { get; set; }

        //Terület számító metódus (függvény). Nem vár paramétert, a sugár tulajdonságot használja
        public double Terulet()
        {
            double t = Math.Pow(sugar, 2) * Math.PI;
            return t;
        }

        //Kerület számító metódus (függvény). Nem vár paramétert, a sugár tulajdonságot használja
        public double Kerulet()
        {
            double k = 2*sugar * Math.PI;
            return k;
        }
    }
}
