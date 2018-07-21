using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kor
{
    //kör kerület és teruletszámítása OOP módon
    class Kor
    {
        //adattag
        public double sugar;

        //konstruktor
        public Kor(double sugar)
        {
            this.sugar = sugar;

        }

        public void Terulet()
        {
            Console.WriteLine("A kör területe:{0}", Math.Pow(this.sugar, 2) * Math.PI);
        }

        public void Kerulet()
        {
            Console.WriteLine("A kör kerülete:{0}", 2 * this.sugar * Math.PI);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //egy Kor típusú objektum létrehozása(példányosítás)
            Kor k = new Kor(1);
            k.Terulet();
            k.Kerulet();

            Kor k2 = new Kor(10);
            k2.Terulet();
            k2.Kerulet();


            Console.ReadLine();
        }//main
    }//program

}
