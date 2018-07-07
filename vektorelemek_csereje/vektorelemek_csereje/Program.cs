using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektorelemek_csereje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5] { 5, 8, 1, 4, 9 };

            Kiir(szamok);

            Console.WriteLine("\n----------------------------------------------------------");

            //a vektor átadása cím szerint történik, mert referencia típus! 
            //az eredeti vektor fog változni!
            Csere(szamok, 0, 4);


            Kiir(szamok);



            Console.ReadLine();

        }//main vége

        //eljárás, amely a vektor megadott elemeit felcseréli
        static void Csere(int[] vektor, int i1, int i2)  //formális paraméterek listája
        {
            //nincs index ellenőrzés!nem lehet nagyobb, mint length-1
            int temp = vektor[i1];
            vektor[i1] = vektor[i2];
            vektor[i2] = temp;

        }

        static void Kiir(int[] vektor)
        {
            /*
            for (int i = 0; i < vektor.Length; i++)
            {
                Console.Write("{0}, ", vektor[i]);
            }
            */

            foreach (int szam in vektor)
            {

                Console.Write("{0}, ", szam);
            }
        }
    }

}
