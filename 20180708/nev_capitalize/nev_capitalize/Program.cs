using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nev_capitalize
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Add meg a keresztneved csupa kisbetűvel!:");
            string teljesnev = Console.ReadLine();




            /*
             // 2 tagú névvel
      
            int szokoz = teljesnev.IndexOf(" ");

            string keresztnev = teljesnev.Substring(0, szokoz);
            string vezeteknev = teljesnev.Substring(szokoz+1, (teljesnev.Length-keresztnev.Length-1));


            Console.WriteLine(Capitalize(keresztnev) + " " +Capitalize(vezeteknev));

            Console.WriteLine();

      */

            string[] nevek = teljesnev.Split(' ');
          

            string nagybetus_nev = "";

            for (int i = 0; i < nevek.Length; i++)
            {
                nagybetus_nev += Capitalize(nevek[i]) + " ";
            }


            Console.WriteLine(nagybetus_nev);


            Console.ReadLine();

        }//main

        static string Capitalize(string kicsinev)
        {


            string elso = Convert.ToString(kicsinev[0]).ToUpper();

            string tobbi = kicsinev.Remove(0, 1);

            string nev = Convert.ToString(kicsinev[0]).ToUpper() + kicsinev.Remove(0, 1);

            return nev;
        }
    }

}
