using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv_oop
{
    class Konyv
    {
        //adattagok
        //ha az adattagok nem publikusak, más osztályok nem láthatják
        public string cim;
        public string szerzo;
        public string kiado;
        public double ar;
        public int darabszam;
        public bool van_e;

        //konstruktor
        public Konyv(string cim, string szerzo, string kiado, double ar, int darabszam, bool van_e)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiado = kiado;
            this.ar = ar;
            this.darabszam = darabszam;
            this.van_e = van_e;
            this.Checknumber();
        }

        //ha nincs belőle egy sem, ne legyen készlete sem
        public void Checknumber()
        {
            if (this.darabszam == 0)
            {
                this.van_e = false;
            }
        }

        public void Akcijo()
        {
            if (this.darabszam > 3)
            {
                this.ar *= 0.9;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //példányosítás
            Konyv k1 = new Konyv("A kőszívű ember fiai", "Jókai Mór", "Budapest Könyvkiadó", 3450, 5, true);
            Konyv k2 = new Konyv("Programozás 2 hét alatt", "Tóth Marcell", "Libri", 6753, 0, true);
            Konyv k3 = new Konyv("Programozas 2 nap alatt", "Tóth Péter", "Alexandra", 4300, 0, false);

            //vektor a könyv objektumokból
            Konyv[] minden_konyv = new Konyv[3];
            minden_konyv[0] = k1;
            minden_konyv[1] = k2;
            minden_konyv[2] = k3;

            foreach (Konyv konyv in minden_konyv)
            {
                //konyv.Checknumber(); konstruktorba beleraktam
                konyv.Akcijo();
                Console.WriteLine("A könyv címe: {0}, \nszerzője:{1}, \nkiadója:{2}, \nára:{3}, \ndarabszáma:{4}, \nvan-e most:{5}",
                    konyv.cim, konyv.szerzo, konyv.kiado, konyv.ar, konyv.darabszam, konyv.van_e);

                Console.WriteLine("-----------------------------------");
            }

            Console.ReadLine();
        }
    }

}
