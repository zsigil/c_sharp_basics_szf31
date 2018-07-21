using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emberek_oop
{
    class Emberek //osztály létrehozása
    {
        //az osztály adattagjai
        public string nev;
        public int kor;
        public string nem;

        //konstruktor - objektum inicializálása és példányosítása
        //speciális szerepű metódus

        public Emberek(string neve, int kor, string neme)
        {
            nev = neve;
            this.kor = kor; //mert a nevek megegyeznek
            nem = neme;
            Console.WriteLine("{0} létrehozva, kora {1} ev, neme: {2}", this.nev, this.kor, this.nem);
        }


        //az osztály metódusai(függvények, eljárások)
        public void Ir()
        {
            Console.WriteLine("{0} most ír", nev);
        }


        public void Olvas()
        {
            Console.WriteLine("{0} most olvas", nev);
        }



    }//emberek osztaly vége



    //A program "fő osztálya"
    class Program
    {
        // a program fő függvénye(compiler belépési pontja)
        static void Main(string[] args)
        {
            //objektum példányosítása
            //létrehozzuk az Emberek osztály egy konkrét példányát
            //meghívjuk a konstruktorát
            //a példányosított objektum tartalmaz mindent, az adattagokat, metódusokat is
            Emberek e = new Emberek("Micimackó", 3, "lány");
            Emberek a = new Emberek("Róbert Gida", 5, "fiú");

            Console.WriteLine();

            //adattagok elérése
            Console.WriteLine("{0} : kora {1} ev, neme: {2}", e.nev, e.kor, e.nem);
            Console.WriteLine("{0} : kora {1} ev, neme: {2}", a.nev, a.kor, a.nem);

            Console.WriteLine();

            //metódusok elérése
            e.Ir();
            e.Olvas();
            a.Ir();
            e.Olvas();

            Console.ReadLine();
        }//main
    }//program

}
