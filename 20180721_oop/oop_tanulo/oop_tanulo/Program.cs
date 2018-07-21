using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_tanulo
{
    //tanuló sztály: név, átlag, sztály,
    class Tanulo
    {
        public string nev;
        public double atlag;
        public string osztaly;
        public string varos;

        public Tanulo(string nev, double atlag, string osztaly, string varos)
        {
            this.nev = nev;
            this.atlag = atlag;
            this.osztaly = osztaly;
            this.varos = varos;
        }

        public Tanulo(string nev, double atlag, string osztaly)
        {
            this.nev = nev;
            this.atlag = atlag;
            this.osztaly = osztaly;
        }

        public Tanulo()  //ilyenkor is elérhető lesz az összes adattag, érték nélkül
        {

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Tanulo emoke = new Tanulo("Emőke", 4.6, "hetedik cé", "Kiskunmajsa");
            Tanulo istvan = new Tanulo("István", 2.1, "10.c");
            Tanulo bela = new Tanulo("Béla", 3.2, "6.a", "Budapest");
            Tanulo bozsi = new Tanulo("Böske", 4.9, "7.b", "Pécel");
            Tanulo mari = new Tanulo("Maris", 2.3, "5.d", "Sopron");

            Console.WriteLine("{0} átlaga {1}, {2} osztályos tanuló , {3} városában lakik", emoke.nev, emoke.atlag, emoke.osztaly, emoke.varos);
            Console.WriteLine("{0} átlaga {1}, {2} osztályos tanuló", istvan.nev, istvan.atlag, istvan.osztaly);

            //Tanulo objektum típusú vektor létrehozása
            Tanulo[] minden_tanulo = new Tanulo[5];

            minden_tanulo[0] = emoke;
            minden_tanulo[1] = istvan;
            minden_tanulo[2] = bela;
            minden_tanulo[3] = bozsi;
            minden_tanulo[4] = mari;

            for (int i = 0; i < minden_tanulo.Length; i++)
            {
                Console.WriteLine("{0}, {1},{2},{3}", minden_tanulo[i].nev, minden_tanulo[i].atlag, minden_tanulo[i].osztaly, minden_tanulo[i].varos);
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (Tanulo tanulo in minden_tanulo)
            {
                Console.WriteLine("{0}, {1},{2},{3}", tanulo.nev, tanulo.atlag, tanulo.osztaly, tanulo.varos);
            }

            Console.WriteLine("--------------------------------------------------");


            double atlagok_osszege = 0;

            foreach (Tanulo tanulo in minden_tanulo)
            {
                atlagok_osszege += tanulo.atlag;
            }

            Console.WriteLine("tanulók átlaga: {0}", atlagok_osszege / minden_tanulo.Length);


            Tanulo majom = new Tanulo();
            Console.WriteLine(majom.nev);//nem dob hibát, csak üres lesz
            majom.nev = "maki";
            Console.WriteLine(majom.nev);
            //majom.szemszin = "kék";  így NEM lehet létrehozni


            Console.ReadLine();
        }
    }

}
