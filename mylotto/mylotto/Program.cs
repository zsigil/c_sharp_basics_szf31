using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylotto
{
    class Program
    {
        static void Main(string[] args)
        {
        // lottószámok sorsolása
                
                // a) kell 90 db int, utána megkeverjük 

                int[] deck = new int[90];

                for (int i = 0; i < 90; i++)
                {
                    deck[i] = i + 1;
                }

                Random r = new Random();

            for (int j = 0; j < 500; j++)
            {
                int mit = r.Next(90);
                int mire = r.Next(90);
                int temp = deck[mit];
                deck[mit] = deck[mire];
                deck[mire] = temp;

            }
            /*
            for (int i = 0; i < 90; i++)
            {
                Console.Write("{0}, ", deck[i]);
            }
            */

            int[] sorsolas = new int[5];
            Array.Copy(deck, sorsolas, 5);
            Array.Sort(sorsolas);


            // tippek bekérése
            int tipp = 0;
            int[] tippek = new int[5];

            while (tipp != 5)
            {
                try
                {
                    Console.Write("Kérek egy tippet 1-90 között!:{0}. tipp: ", tipp + 1);
                    int ujtipp = int.Parse(Console.ReadLine());
                    bool bennevan = tippek.Contains(ujtipp);
                    if (ujtipp < 91 && ujtipp > 0 && !bennevan)
                    {
                        tippek[tipp] = ujtipp;
                        tipp++;
                    }
                    else
                    {
                        Console.WriteLine("rossz tipp");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("broáf");
                    continue;  
                }             

            }

            // találatok megadása

            Console.WriteLine("\nA nyertes számok: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}, ", sorsolas[i]);
            }


            Console.WriteLine("\nA te számaid: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}, ", tippek[i]);
            }

            int talalat = 0;

            for (int i = 0; i < 5; i++)
            {
                if (sorsolas.Contains(tippek[i]))
                {
                    talalat++;
                }
            }

            Console.WriteLine("\nA találatok száma: {0}", talalat);


            Console.ReadLine();
        }// main vége
    }
}
