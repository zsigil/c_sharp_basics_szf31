using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valtozok_az_alprogramokban
{
    class Program
    {
        static void Main(string[] args)
        {
            int z; // main változója

            //Console.WriteLine(a); //fő függvény nem látja az "a" változót

            //int szam = Valtozo(z=3); // okés
            //Valtozo(z = 3); //okés

            Console.WriteLine(Valtozok(0));  // 5, 1


            Console.WriteLine("");
            Console.ReadLine();
        }// main vége


        //alprogram, függvény (van visszatérési érték)


        static int Valtozok(int valamik)
        {
            //Console.WriteLine(a); // alprogramok sem látják egymás változóit
            int b = Valtozo(5);  // az alprogramok egymásból meghívhatók, sorrendjük mindegy

            return 1;
        }

        //alprogram, függvény (van visszatérési érték)
        static int Valtozo(int valami)
        {
            //z = 5; //a fő függvény változói nem láthatók az alprogramban
            int a = valami;
            Console.WriteLine(a); //lokális változó, csak az alprogramon belül él
            return 1;
        }

    }

}
