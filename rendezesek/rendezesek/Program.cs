using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendezesek
{
    class Program
    {
        static void Main(string[] args)
        {


            #region // tömb elkészítése
            int n = 10;
            int[] szamok = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                szamok[i] = r.Next(20);
            }

            // tömb kiíratása

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ", szamok[i]);
            }
            #endregion

            // buborékos keresés

            for (int i = n-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (szamok[j] > szamok[j + 1])
                    {
                        int temp = szamok[j];
                        szamok[j] = szamok[j + 1];
                        szamok[j + 1] = temp;
                    }

                }

               
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ", szamok[i]);
            }



            Console.ReadLine();
        }// main vége


    }
}
