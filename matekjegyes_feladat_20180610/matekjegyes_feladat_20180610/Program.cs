using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matekjegyes_feladat_20180610
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Feladat: kérjünk be 'n' db (pl 10) osztályzatot (1-5-ig), hülyebiztosan,
             * majd ezekből:
             * számoljunk átlagot
             * hányan kaptak átlag feletti jegyet
             * mi a legjobb jegy
             * bukott-e valaki
             * ha bukott, mi az indexe az első bukott tanulónak
             */

            // hány tanuló jegyét akarjuk vizsgálni (n)
            int n;
            Console.WriteLine("Elképesztő tanári program");

            while (true) // addig csinálom a cirkuszt, amíg nem ad értelmes inputot
            {
                Console.Write("Hány tanuló jegyét szeretné megadni?(max 50): ");
                try
                {
                    int valasz = int.Parse(Console.ReadLine());
                    if (valasz <1 || valasz>50)
                    {
                        Console.WriteLine("min 1, max 50 diák");
                        continue;
                    }
                    //ha jó számot adott:
                    n = valasz;
                    break;  // megvan, amit akarok, kilépek a ciklusból!
                }
                catch (Exception)
                {
                    Console.WriteLine("ez nem jött össze, fussunk neki megint");
                }
            }

            Console.WriteLine("{0} darab osztályzatot fogok bekérni, 1-5-ig", n);

            // n elemű tömb létrehozása csekkolt értékekkel "osztalyzatok"
            int[] osztalyzatok = new int[n];
            int probalkozas_index = 0;
            int bekerve;


            while (probalkozas_index<n)  // pl 10 elemű tömb esetén az index 0-9-ig van
            {
                try
                {
                    Console.Write("\n{0}. tanuló jegye:", probalkozas_index + 1);
                    bekerve = int.Parse(Console.ReadLine());
                    if (bekerve<1 || bekerve>5)
                    {
                        Console.WriteLine("Az osztályzatok 1-5-ig vannak!");
                        continue;  // újból kérje be, rossz a szám
                    }
                    osztalyzatok[probalkozas_index] = bekerve;
                    probalkozas_index += 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("Az osztályzatok egész számok, 1-5-ig!");
                }
            }

            Console.Clear();
            Console.WriteLine("\nAz osztályzatok :");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}; ", osztalyzatok[i]);
            }

            Console.WriteLine();

            // összeget számolunk az átlaghoz

            int osszeg = 0;

            for (int i = 0; i < n; i++)
            {
                osszeg += osztalyzatok[i];
            }

            // az átlag az összeg/db

            double atlag = 0;
            atlag = (double)osszeg / n;  // kasztolni kell, mindkettő int
            int atlagnal_jobb = 0;
            bool bukott = false;
            int bukott_index = -1; // ilyen index biztos nincs
            int bukottak_szama = 0;
            int legjobb_jegy = 1; // ezt biztos sikerült elérni vkinek

            //végigvizslatjuk a tömböt
            for (int i = 0; i < n; i++)
            {
                if (osztalyzatok[i] > atlag)
                {
                    atlagnal_jobb++;
                }

                if (osztalyzatok[i]> legjobb_jegy)
                {
                    legjobb_jegy = osztalyzatok[i];
                }

                if (osztalyzatok[i]==1)  //megbukott
                {
                    bukottak_szama++; 

                    if (!bukott)   //első bukottnak kiszedem az indexét (még false)
                    {
                        bukott_index = i;                       
                    }
                    bukott = true;
                }

            }


            Console.WriteLine("\nAz osztályzatok átlaga:{0}", atlag);
            Console.WriteLine("\nAz átlagnál jobb volt:{0} db tanuló.", atlagnal_jobb);
            Console.WriteLine("\nA legjobb jegy : {0}", legjobb_jegy);

            if (bukott)  // akkor lesz true, ha valaki bukott
            {
                Console.WriteLine("\n{0} darab tanuló bukott, első bukott tanuló INDEXE: {1}", bukottak_szama, bukott_index);
            }
            else
            {
                Console.WriteLine("\nNem bukott senki.");
            }

            Console.ReadLine();
        }//main vége
    }
}
