using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szorzotabla
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<11; i++)
            {
                for(int j=1; j < 11; j++)
                {
                    Console.Write((i*j) + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

