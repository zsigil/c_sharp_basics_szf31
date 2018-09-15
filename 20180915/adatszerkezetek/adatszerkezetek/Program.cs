using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatszerkezetek
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista adatszerkezet
            //nem kell megmondani, hogy hány elemű lesz
            //deklaráció

            List<int> lista = new List<int>()
            {
               8,5,87,52,32

            };

            //Linq lekérdezések használata
            //általános, egységes lekérdező nyelv 
            //különböző adatszerkezetekhez és adatbázisokhoz

            /* 
             felépítése: 
             eredmény = from azonosító in kifejezés select kifejezés
             ->a kifejezés jelöli a forrást, az azonosító a forrás egyes elemeit
             -> select-tel választjuk ki az összes elemet az adatforrásból
             */

            // link lekérdezés, "var" <- ő dönti el, milyen lesz a típusa
            //ez az összes: szamok-ból az összes szám
            var eredmeny = from szamok in lista select szamok;

            //sima iterable, végig kell rajta menni
            Console.WriteLine(eredmeny);

            //első elem
            Console.WriteLine(eredmeny.First<int>());
            Console.WriteLine("---------------------------------------------");

            foreach (var item in eredmeny)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");

            var eredmeny2 = from szamok in lista select szamok * 2;

            foreach (var item in eredmeny2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");

            var eredmeny3 = from szamok in lista where (szamok > 30) select szamok;

            foreach (var item in eredmeny3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");

            var eredmeny4 = from szamok in lista orderby szamok ascending select szamok;

            foreach (var item in eredmeny4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");

            /* 
             verem adatszerkezet (stack)
             LIFO: last in , first out
             */

            //deklaráció

            Console.WriteLine("----------------STACK---------------------");
            Console.WriteLine("---------------------------------------------");

            Stack<int> verem = new Stack<int>();

            verem.Push(8);
            verem.Push(32);

            Console.WriteLine(verem);

            int utoljara = verem.Pop();
            Console.WriteLine(utoljara);

            int utoljara2 = verem.Pop();
            Console.WriteLine(utoljara2);




            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");


            /*hibát dob, ha többet veszek ki, mint ami van
            int utoljara3 = verem.Pop();
            Console.WriteLine(utoljara3);
            */

            verem.Push(50);
            verem.Push(12);

            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-------------------SOR-----------------------");


            /* SOR
             * FIFO adatszerkezet - first in, first out
             * bármikor lehet hozzá elemet rakni, 
             * de csak azt lehet kivenni, amit először beletettünk
             */

            //deklaráció

            Queue<string> my_sor = new Queue<string>();

            //műveletek
            my_sor.Enqueue("bla");
            my_sor.Enqueue("huha");

            Console.WriteLine(my_sor);

            foreach (var item in my_sor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");
            string my_string = my_sor.Dequeue();

            Console.WriteLine(my_string);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-----------------HALMAZ----------------------");

            /*
             *HALMAZ
             * egy elem csak egyszer szerepelhet
             * nincs sorrend, nincs index
             */

            //deklaráció
            HashSet<char> halmaz = new HashSet<char>();
            Console.WriteLine(halmaz);

            halmaz.Add('b');
            halmaz.Add('x');

            foreach (var item in halmaz)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");


            halmaz.Remove('x');
            foreach (var item in halmaz)
            {
                Console.WriteLine(item);
            }

            halmaz.Add('h');
            halmaz.Add('t');

            Console.WriteLine( "-------------------------------------");

            foreach (var item in halmaz)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(halmaz.Contains('t'));

            //példa a halmazra
            HashSet<char> elfogadott_betu = new HashSet<char>();
            elfogadott_betu.Add('i');
            elfogadott_betu.Add('n');
            Console.WriteLine("csak i vagy n betűt üthetsz le");
            char betu = char.Parse(Console.ReadLine());

            if (elfogadott_betu.Contains(betu))
            {
                Console.WriteLine("jó betű volt, nem vagy ökör");
            }
            else
            {
                Console.WriteLine("ökör vagy");
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-----------------SZÓTÁR----------------------");

            /*
             kulcs és hozzá tartozó érték-párosok tárolására

             */
            Dictionary<char, string> szotar = new Dictionary<char, string>();

            szotar.Add('c', "cé");
            szotar.Add('a', "aa");
            szotar.Add('b', "bé");
            szotar.Add('k', "ká");
            szotar['c'] = "piros";

            foreach(KeyValuePair<char,string> kvp in szotar)
            {
                Console.WriteLine("{0} => {1} ", kvp.Key, kvp.Value);
            }

            Console.WriteLine("------------------------------------------");
            szotar.Remove('c');

            foreach (KeyValuePair<char, string> kvp in szotar)
            {
                Console.WriteLine("{0} => {1} ", kvp.Key, kvp.Value);
            }
            Console.ReadLine();

        }
    }
}
