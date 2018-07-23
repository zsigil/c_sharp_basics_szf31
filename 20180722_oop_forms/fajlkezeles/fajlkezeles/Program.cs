using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //input-output műveletek osztályai

namespace fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            //szövegfájl olvasás
            //fájl eléréséhez létrehozunk egy filestream típusú objektumot, 
            //megfelelő paraméterekkel meghívjuk a konstruktorát (1.lépés)


            FileStream fs = new FileStream("ures.txt",FileMode.Open, FileAccess.Read);
           

            //2. lépés: létrehozunk egy olyan objektumot, amely az olvasást valósítja meg
            //StreamReader objektum paraméterként megkapja a filestream objektumot(ez tartalmazza
            //az infot a file eléréséhez

            StreamReader sr = new StreamReader(fs);

            //egy sor beolvasása  (string lesz)
            string s = sr.ReadLine();


            //többi sor beolvasása, amíg van
            while (!sr.EndOfStream)    //vagy s!=null
            {
                Console.WriteLine(s);
                s = sr.ReadLine();
            }

            sr.Close(); //az olvasást és a handlert is le kell zárni!
            fs.Close();


            //írás szöveges fájlba (új sorok hozzáfűzése)
            //1.lépés létrehozzukk az objektumot az íráshoz

            FileStream fsw = new FileStream("szoveg.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fsw);


            string knev;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("keresztnevet kérek:");
                knev = Console.ReadLine();
                //sw.WriteLine(knev);
                sw.Write(knev);
                sw.Write(Environment.NewLine);

            }
            


            sw.Close();
            fsw.Close();

            //nem létező létrehozása - ha volt ilyen, felülíródik!

            FileStream fs2 = new FileStream("szoveg3.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(fs2);

            string knev2;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("keresztnevet kérek:");
                knev2 = Console.ReadLine();
                //sw.WriteLine(knev);
                sw2.Write(knev2);
                sw2.Write(Environment.NewLine);

            }

            sw2.Close();
            fs2.Close();




            Console.ReadLine();
        }
    }
}
