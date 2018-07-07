using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfoku_egyenlet_megoldasa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ax^2+bx+c=0 MEGOLDÁSA");

            double a;
            while (true)
            {
                Console.Write("Kérem az 'a' értékét:");
                try
                {
                    double bekert_a = double.Parse(Console.ReadLine());
                    if (bekert_a == 0)
                    {
                        Console.WriteLine("\nez az érték nem lehet nulla!");
                    }
                    else
                    {
                        a = bekert_a;
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("\nszámot kérek, mi nem nulla!");
                }
            }

            double b;
            while (true)
            {
                Console.Write("Kérem a 'b' értékét:");
                try
                {
                    double bekert_b = double.Parse(Console.ReadLine());
                    b = bekert_b;
                    break;

                }
                catch (Exception)
                {

                    Console.WriteLine("\nszámot kérek!");
                }
            }

            double c;
            while (true)
            {
                Console.Write("Kérem a 'c' értékét:");
                try
                {
                    double bekert_c = double.Parse(Console.ReadLine());
                    c = bekert_c;
                    break;

                }
                catch (Exception)
                {

                    Console.WriteLine("\nszámot kérek!");
                }
            }

            Console.WriteLine("OKÉ, a={0}, b={1}, c={2}", a, b, c);

            double x1;
            double x2;
            double ellenorzes1;
            double ellenorzes2;


            double d = Math.Pow(b, 2) - (4 * a * c); //diszkrimináns = b^2-4ac
            Console.WriteLine("A diszkrimináns értéke:{0}", d);

            if (d < 0)
            {
                Console.WriteLine("Rettenetesen sajnálom, nincs megoldás");
            }
            else if (d == 0)
            {
                //pl. a=2,b=4,c=2
                x1 = -b / (2 * a);
                Console.WriteLine("Pontosan egy megoldás van, x={0}", x1);
                ellenorzes1 = a * Math.Pow(x1, 2) + b * x1 + c;
                Console.WriteLine("Ha ez 0, akkor jól dolgoztam:{0}", ellenorzes1);


            }

            else
            {
                //pl. a=5, b=-3, c=-2  x1=1, x2=0,4
                //valszeg kerekítési hiba lesz a visszaellenőrzésben, ezzel kezdeni kéne vmit

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Pontosan két megoldás van, x1={0}, x2={1}", x1, x2);
                ellenorzes2 = a * Math.Pow(x2, 2) + b * x2 + c;
                ellenorzes1 = a * Math.Pow(x1, 2) + b * x1 + c;


                double ker_ellenorzes2 = Math.Round(ellenorzes2, 10);
                Console.WriteLine("10-re kerekítve az ellenőrzés2: {0}", ker_ellenorzes2);

                double ker_ellenorzes1 = Math.Round(ellenorzes1, 10);
                Console.WriteLine("10-re kerekítve az ellenőrzés2: {0}", ker_ellenorzes1);



                bool errorcheck = false;

                if (ker_ellenorzes1 == ker_ellenorzes2 && ker_ellenorzes2 == 0)
                {
                    errorcheck = true;
                }

                if (errorcheck)
                {
                    Console.WriteLine("ellenőrzés oké");
                }



                decimal test_decimal1 = Convert.ToDecimal(ellenorzes1);


                Console.WriteLine("Egyébként ellenőrzés1:{0},ellenőrzés2: {1}", ellenorzes1, ellenorzes2);
            }

            /*
             * lehet még: Convert.ToSingle, Convert.ToInt64
            decimal test_mytest1 = Convert.ToDecimal(3.00000000000002); //ezt még így írja ki, még egy nullával már 3
            Console.WriteLine("decimal:{0}", test_mytest1);

            double test_mytest2 = Math.Round(3.00000000002, 10);
            Console.WriteLine("decimal round:{0}", test_mytest2);

            */
            Console.ReadLine();
        }//main vége
    }

}
