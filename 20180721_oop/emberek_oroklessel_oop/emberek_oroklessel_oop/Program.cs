using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emberek_oroklessel_oop
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

    //a felnőttek osztály az emberekből van leszármaztatva
    class Felnottek : Emberek
    {
        public string lakhely; //saját adattag

        //konstruktor
        // base metódus az ősosztály adattagjait használja
        public Felnottek(string nev, int kor, string nem) : base(nev, kor, nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;

        }

        //konstruktor 2.
        public Felnottek(string nev, int kor, string nem, string lakhely) : base(nev, kor, nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
            this.lakhely = lakhely;

        }

        //super átírva
        new public void Ir()
        {
            Console.WriteLine("{0} most felnőtten ír, nem ember", nev);
        }


        //saját metódus
        public void Beszel()
        {
            Console.WriteLine("{0} most beszél.", this.nev);
        }

    }



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

            Console.WriteLine();
            Felnottek f1 = new Felnottek("Géza", 23, "férfi");
            Console.WriteLine("{0} : kora {1} ev, neme: {2}", f1.nev, f1.kor, f1.nem);

            Felnottek f2 = new Felnottek("Juci", 30, "nő", "Győr");
            Console.WriteLine("{0} : kora {1} ev, neme: {2}, lakik: {3}", f2.nev, f2.kor, f2.nem, f2.lakhely);

            f2.Ir(); //örökölt
            f2.Olvas(); //örökölt
            f2.Beszel(); //saját

            Console.ReadLine();
        }//main
    }//program

}
