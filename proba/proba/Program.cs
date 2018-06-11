using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("prímszámmegmondó kisokos");

            bool more = true;

            while (more)
            {


                int mynumber = Szambekeres();
                if (IsPrime(mynumber))
                {
                    Console.WriteLine("hurrá, prím");
                }
                else
                {
                    Console.WriteLine("nemnyert");
                }

                Console.Write("még? y/n");
                string meg = Console.ReadLine();
                if (meg != "y")
                {
                    more = false;
                    Console.WriteLine("thank you for playing!");
                }
                Console.ReadLine();
            }
        } // main vége


        static int Szambekeres()
        {
            Console.Write("kérem az egész számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            return szam;

        }

        static bool IsPrime(int tocheck)
        {
            if (tocheck == 0 || tocheck == 1 || tocheck == 2)
            {
                Console.WriteLine("ez hülyeség");
                return false;
            }
            for (int i = 2; i < Math.Sqrt(tocheck); i++)
            {
                if (tocheck % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        
    }// program vége
}
