using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_szamitasok
{
    static public class Szamitas
    {
        //property 
        //speciális metódus az adattagok beállítását végzi
        //ellenőrzötten

        static public double sugar { get; set; }


        //metódusok
        //terület számítása
        static public double Terulet()
        {
            double t = Math.Pow(sugar, 2) * Math.PI;
            return t;
        }

        //kerület számítás
        static public double Kerulet()
        {
            double k = 2 * sugar * Math.PI;
            return k;
        }



    }
}
