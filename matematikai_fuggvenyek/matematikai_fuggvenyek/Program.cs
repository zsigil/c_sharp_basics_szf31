using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematikai_fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot:");
            double mynumber = double.Parse(Console.ReadLine());

            double negyzet = Math.Pow(mynumber, 2);
            double negyzetgyok = Math.Sqrt(mynumber);
            double kerekites = Math.Round(mynumber);
            double truncated = Math.Truncate(mynumber); //csak húz egy vonalat a tizedesnél
            double floored = Math.Floor(mynumber); //floor- mínusz számoknál van különbség! tőle kisebb egész szám
            double ceilinged = Math.Ceiling(mynumber); //tőle nagyobb egész szám
            double abszolut = Math.Abs(mynumber);
            double my_pi = Math.PI;


            //szögfüggvények: mindig radiánban kell megadni
            double radian = Math.PI / 180 * mynumber; // ha mynumber fokban van megadva


            double sinus = Math.Sin(radian);
            double cosinus = Math.Cos(radian);
            double tangens = Math.Tan(radian);
            double cotangens = 1 / tangens;

            //kiíratások
            Console.WriteLine("\nA megadott szám a : {0}.", mynumber);
            Console.WriteLine("A megadott szám négyzete : {0}.", negyzet);
            Console.WriteLine("A megadott szám négyzetgyöke : {0:F5}.", negyzetgyok);
            Console.WriteLine("A megadott szám kerekítve : {0}.", kerekites);
            Console.WriteLine("A megadott szám truncatedje : {0}.", truncated);
            Console.WriteLine("A megadott szám floorja : {0}.", floored);
            Console.WriteLine("A megadott szám ceilingje : {0}.", ceilinged);
            Console.WriteLine("A megadott szám abszolút értéke : {0}.", abszolut);
            Console.WriteLine("Pí: {0}.", my_pi);
            Console.WriteLine("Ha a szám fok, a radián: {0}.", radian);
            Console.WriteLine("Sinus: {0}.", sinus);
            Console.WriteLine("Cosinus: {0}.", cosinus);
            Console.WriteLine("tangens: {0}.", tangens);
            Console.WriteLine("cotangens: {0}.", cotangens);

            Console.WriteLine("-----------------------------------------------------");

            Console.Write("Kérek egy számot szinuszban:");
            double mysinus = double.Parse(Console.ReadLine());

            //inverz szögfüggvények A...
            double fok = Math.Asin(mysinus) * 180 / Math.PI;  //(Asin radiánban adja meg, abból csinálok fokot)

            Console.WriteLine("A szinuszérték fokban: {0}", fok);
            Console.ReadLine();
        }//main vége
    }

}
