using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurziv_faktorialis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            int x = int.Parse(Console.ReadLine());
            int myfactorial = GetFactorial(x);


            Console.WriteLine("{0} faktoriálisa : {1}", x, myfactorial);


            int myfactorial2 = GetFactorial2(x);


            Console.WriteLine("{0} faktoriálisa : {1}", x, myfactorial2);


            Console.ReadLine();
        }

        static int GetFactorial(int number)
        {

            // 0!=1(matematikai megállapodás)

            if (number > 1)
            {
                int factorial = number * GetFactorial(number - 1);
                return factorial;
            }
            else
            {
                return 1;
            }

            /*
             * pl 5-nél:
             * 1. factorial = 5* getfact(4)
             * 2. factorial = 4*getfact(3)
             * 3. factorial = 3*getfact(2)
             * 4. factorial = 2*getfact(1)
             * ez már nem nagyobb, mint egy , egyet küld vissza, indulunk visszafelé
             * 4.factorial = 2*1 =2
             * 3. afctorial = 3*2
             * 2. 4*3*2
             * 1. 5*4*3*2
            */

        }

        static int GetFactorial2(int number)
        {

            // 0!=1(matematikai megállapodás)

            return number <= 1 ? 1 : number * GetFactorial2(number - 1);

        }

    }

}
