using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor_terulete_es_kerulete_alprogramokkal
{
    class Program
    {
        #region // alprogramok
        static void Kiir(double r, double t, double k)
        {
            Console.WriteLine("A {0} sugarú kör területe {1:F5}, területe: {2:F5}", r, t, k);
        }


        static double KorKerulet(double r)
        {
            double kerulet = 2 * r * Math.PI;
            return kerulet;
        }

        static double KorTerulet(double r)
        {
            double terulet = r * r * Math.PI;
            return terulet;
        }

        #endregion

        static void Main(string[] args)
        {
            Console.Write("add meg a kör sugarát:");
            double kor_sugara = double.Parse(Console.ReadLine());

            Kiir(kor_sugara, KorTerulet(kor_sugara), KorKerulet(kor_sugara));


            Console.ReadLine();
        }
    }

}
