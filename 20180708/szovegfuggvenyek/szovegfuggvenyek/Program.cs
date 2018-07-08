using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szovegfuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "nevemnevem";
            string sz = "NEVEMNEVEM";
            string g = " nevemnevem";

            //szövegkezelő függvények

            //mire végződik/mivel kezdődik  - logikai értéket küld vissza
            Console.WriteLine(s.EndsWith("em"));  //true
            Console.WriteLine(s.EndsWith("EM"));  //false
            Console.WriteLine(s.StartsWith("ne")); //true

            //adott szövegrészlet kezdő pozíciója (csak az első előfordulása!)
            Console.WriteLine(s.IndexOf("ve")); //2

            //utolsó előfordulás
            Console.WriteLine(s.LastIndexOf("ve")); //7


            //szúrjuk bele egyiket a másikba
            Console.WriteLine(s.Insert(3, sz)); //nevNEVEMNEVEMemnevem

            //hossz lekérdezése
            Console.WriteLine(s.Length); //10

            //szövegrész eltávolítása stringből
            Console.WriteLine(s.Remove(5, 5));  //nevem

            //cseréljünk szövegrészletet
            Console.WriteLine(s.Replace("nevem", "nevek"));

            //szövegrészlet lekérdezése
            Console.WriteLine(s.Substring(5, 5));

            //kisbetű, nagybetű
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(sz.ToLower());

            //szóközök eltávolítása
            Console.WriteLine(g.Trim());


            //tartalmaz-e szövegrészletet
            Console.WriteLine(s.Contains("ev")); //true
            Console.WriteLine(s.Contains("ba")); //false

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(s); //az eredeti s nem változik ezektől
            Console.WriteLine(sz);
            Console.WriteLine(g);
            Console.WriteLine(s[1]);


            Console.WriteLine("-----------------------------------------------");

            //további szövegkezelő lehetőségek
            string a = "Vilmos";
            string b = "Walter";

            //stringek összehasonlítása
            int x = String.Compare(a, b); //-1, 0, 1 lehet az értéke
            Console.WriteLine(x); //-1  // a előbb van az abécében

            int k = String.Compare(b, a);
            Console.WriteLine(k); //1 //b hátrébb van az ábécében

            int m = String.Compare(a, a); //betűre megegyezik
            Console.WriteLine(m); //0

            //sztringek összefűzése

            Console.WriteLine(a + b);

            //first: megmutatja egy sorozat első elemét (string, vektor, stb)
            Console.WriteLine(s.First());




            Console.ReadLine();
        }
    }

}
