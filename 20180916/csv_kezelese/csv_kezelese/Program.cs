using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csv_kezelese
{
    class Program
    {   
        //comma separated values
        //egyszerű text file, Excel meg tudja nyitni
        //célszerű utf-8 kódolást használni(jegyzettömbben átmenteni)
        static void Main(string[] args)
        {

            #region CSV feldolgozás listával
            // Streamreader objektum a fájl eléréséhez
            StreamReader sr = new StreamReader(@"C:\Users\tanulo1117\Documents\zsigmond_ildiko\c_sharp\20180916\proba.csv", Encoding.UTF8);

            //beolvassuk a fájlt egy listába
            List<string> lista = new List<string>();//egész sort tárolja
            List<string> lista1 = new List<string>();//ebben tárolom majd minden sor első elemét
            List<string> lista2 = new List<string>();
            List<string> lista3 = new List<string>();
            List<string> lista4 = new List<string>();

            while (!sr.EndOfStream) // addig megy, amíg nem értük el a fájl végét
            {
                var sor = sr.ReadLine();

                Console.WriteLine(" a sor hossza: {0}", sor.Length);

                var ertek = sor.Split(';'); // sor feldarabolása

                //az üres értéket is bele fogja számolni
                Console.WriteLine("a vektor hossza {0}", ertek.Length);

                lista.Add(sor);
                lista1.Add(ertek[0]); //vektorban indexszel lehet hivatkozni a cuccra
                lista2.Add(ertek[1]);
                lista3.Add(ertek[2]);
                lista4.Add(ertek[3]);

                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("A lista mérete:{0}", lista.Capacity); //ha előre megadtuk a deklarációnál a zárójelben
            Console.WriteLine("A lista elemeinek száma:{0}", lista.Count); // ténylegesen mennyi elemet tartalmaz

            foreach (var item in lista)   //minden listaelem egy sor
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");


            Console.WriteLine("Csak az első elemek: ");
            foreach (var item in lista1)   //minden sor első értéke
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Csak a 2. elemek: ");
            foreach (var item in lista2)   //minden sor első értéke
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Csak a 3. elemek: ");
            foreach (var item in lista3)   //minden sor első értéke
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Csak a 4. elemek: ");
            foreach (var item in lista4)   //minden sor első értéke
            {
                Console.WriteLine(item);
            }


            sr.Close();//reader lezárása

            #endregion


            #region CSV feldolgozása mátrixszal

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--------BEOLVASÁS MÁTRIXBA-------------------");
            Console.WriteLine("---------------------------------------------");
            //Beolvasás mátrixba
            StreamReader sr1 = new StreamReader(@"C:\Users\tanulo1117\Documents\zsigmond_ildiko\c_sharp\20180916\proba.csv", Encoding.UTF8);

            //meg kell határozni , hogy hány sora és oszlopa van a csv fájlnak
            int sorok_szama = 0;
            int oszlopok_szama = 0;

            while (!sr1.EndOfStream)
            {
                var sor = sr1.ReadLine(); // beolvasunk egy sort
                sorok_szama++; //számoljuk a sorokat
                var ertek = sor.Split(';');  //feldaraboljuk a sort

                if (ertek.Length > oszlopok_szama)   //oszlopszám maximumának keresése
                {
                    oszlopok_szama = ertek.Length;
                }
            }

            Console.WriteLine("sorok száma: {0}", sorok_szama);
            Console.WriteLine("oszlopok száma: {0}",oszlopok_szama);
            Console.WriteLine("---------------------------------------------");

            sr1.Close();

            //új readert kell nyitni, hogy dolgozni tudjunk vele
            StreamReader sr2 = new StreamReader(@"C:\Users\tanulo1117\Documents\zsigmond_ildiko\c_sharp\20180916\proba.csv", Encoding.UTF8);

            //mátrix létrehozása, és feltöltése adatokkal
            string[,] csv_matrix = new string[sorok_szama, oszlopok_szama];



            for (int i = 0; i < sorok_szama; i++)
            {
                var sor = sr2.ReadLine(); //beolvasunk egy sort
                var ertekem = sor.Split(';'); //szétcsapjuk a sort

                for (int j = 0; j < oszlopok_szama; j++)
                {
                    csv_matrix[i, j] = ertekem[j]; //hozzáadjuk az oszlopok tartalmát
                }
            }

            for (int i = 0; i < sorok_szama; i++)
            {
                for (int j = 0; j < oszlopok_szama; j++)
                {
                    Console.WriteLine("{0}", csv_matrix[i,j]);
                }
                Console.WriteLine("--------------------------------");
            }


            sr2.Close();

            #endregion
            Console.WriteLine("nyomj le egy entert a kiíratáshoz!");
            Console.ReadLine();

            #region MÁTRIX KIÍRATÁSA CSV-BE

            //CSV fájl írása
            // a mátrix tartalmát kiírjuk egy másik csv fájlba


            StringBuilder csv_string = new StringBuilder();

            string uj_sor = "";

            for (int i = 0; i < sorok_szama; i++)
            {
                for (int j = 0; j < oszlopok_szama; j++)
                {
                    if (j == oszlopok_szama - 1) //ha az utsó, akkor ne rakjon pontosvesszőt
                    {
                        uj_sor = uj_sor + csv_matrix[i, j].ToString();
                    }
                    else
                    {
                        uj_sor = uj_sor + csv_matrix[i, j].ToString() + ";";
                    }

                }
                //hozzáadjuk az új sort a stringbuilder típusú objektumhoz

                csv_string.AppendLine(uj_sor);  //hozzáadjuk az előzőleg összerakott sort
                uj_sor = ""; //ki kell nullázni
                

            }
            //ha nem létezik, létrehozza, ha van már, átírja
            File.WriteAllText(@"C:\Users\tanulo1117\Documents\zsigmond_ildiko\c_sharp\20180916\enirtam.csv", csv_string.ToString(), Encoding.UTF8);

            Console.WriteLine("a fájl írása megtörtént");
            Console.ReadLine();
            #endregion

        }
    }
}
