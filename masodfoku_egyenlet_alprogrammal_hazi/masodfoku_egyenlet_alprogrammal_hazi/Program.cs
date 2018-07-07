using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfoku_egyenlet_alprogrammal_hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2+bx+c=0 MEGOLDÁSA");

            #region adatbekérés, megvan a,b,c
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

            #endregion, 

            double[] myarray = Egyenletmegoldo(a, b, c);

            if (myarray.Length==0)
            {
                Console.WriteLine("nincs megoldás");
            }

            else if (myarray.Length == 1)
            {
                Console.WriteLine("egy megoldás van, x={0}", myarray[0]);
            }

            else if (myarray.Length == 2)
            {
                Console.WriteLine("2 megoldás van, x1={0}, x2={1}", myarray[0], myarray[1]);

            }

            else
            {
                Console.WriteLine("szar van a palacsintában");
            }



            Console.ReadLine();
        }//main vége


        static double[] Egyenletmegoldo(double a, double b, double c)
        {
            double x1;
            double x2;
            double ellenorzes1;
            double ellenorzes2;
            

            double d = Math.Pow(b, 2) - (4 * a * c); //diszkrimináns = b^2-4ac
            Console.WriteLine("A diszkrimináns értéke:{0}", d);

            if (d < 0)
            {
                double[] nincsmegoldas = new double[0];
                return nincsmegoldas;
            }
            else if (d == 0)
            {
                //pl. a=2,b=4,c=2
                x1 = -b / (2 * a);
                ellenorzes1 = a * Math.Pow(x1, 2) + b * x1 + c;

                double ker_ellenorzes1 = Math.Round(ellenorzes1, 10);

                if (ker_ellenorzes1==0)
                {
                    double[] egymegoldas = new double[1];
                    egymegoldas[0] = x1;
                    return egymegoldas;
                }
                else
                {
                    double[] hibastomb = new double[3];
                    return hibastomb;
                }

            }

            else
            {
                //pl. a=5, b=-3, c=-2  x1=1, x2=0,4
              
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                
                ellenorzes2 = a * Math.Pow(x2, 2) + b * x2 + c;
                ellenorzes1 = a * Math.Pow(x1, 2) + b * x1 + c;


                double ker_ellenorzes2 = Math.Round(ellenorzes2, 10);
                double ker_ellenorzes1 = Math.Round(ellenorzes1, 10);
               

                if (ker_ellenorzes1==ker_ellenorzes2 && ker_ellenorzes2 == 0)
                {
                    double[] ketmegoldas = new double[2];
                    ketmegoldas[0] = x1;
                    ketmegoldas[1] = x2;
                    return ketmegoldas;
                }

                else
                {
                    double[] hibastomb = new double[3];
                    return hibastomb;
                }

                
            }
        }

    }

}
