using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------+");
            Console.WriteLine("+-----Fibonacci--------+");
            Console.WriteLine("+----------------------+");

            Console.Write("hány tagú sort szeretnél?:");
            int darab = int.Parse(Console.ReadLine());

            int before = 0;
            int number = 1;
            int next = 0;
            int temp = 0;

            Console.WriteLine("A fibonacci számok:");
            Console.Write("{0}, ", before);
            Console.Write("{0}, ", number);
            int osszeg = 1;

            for (int i = 2; i < darab; i++)
            {
                next = number + before;
                Console.Write("{0}, ", next);

                osszeg = osszeg + next;

                before = number;
                number = next;
               
                 
                


            }
            Console.WriteLine();
            Console.WriteLine("Összegük: {0}", osszeg);
            Console.ReadLine();
        }
    }
}
