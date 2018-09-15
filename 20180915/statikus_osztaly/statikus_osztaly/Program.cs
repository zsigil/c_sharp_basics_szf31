using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statikus_osztaly
{
    static class Szamolas
    {
        static public int x = 50;
        static public int y = 30;

        //lehetnek paraméterei, de csak a statikus adattagokhoz fér hozzá
        static public void Osszead()
        {
            Console.WriteLine("{0} + {1} = {2}", x,y,x+y);
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {

            //statikus, nem kell példányosítani!

            Szamolas.Osszead();
            Console.WriteLine("x: {0}", Szamolas.x);
            Console.ReadLine();
        }
    }
}
