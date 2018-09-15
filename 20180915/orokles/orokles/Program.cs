using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            //példányosítunk
            Emberek Anna = new Emberek("Anna", 23, "nő");
            Anna.Ir();

            Felnottek Bela = new Felnottek("Béla", 50, "férfi");
            Bela.Ir();
            Bela.Beszel();

            Felnottek Maris = new Felnottek("Maris", 72, "nő", "Szombathely");
            Console.WriteLine(Maris.nev);
            Maris.Olvas();
            Maris.Beszel();

            Console.ReadLine();
        }
    }

    class Emberek
    {
        //adattagok
        public string nev;
        public int kor;
        public string nem;

        //konstruktor
        public Emberek(string nev, int kor, string nem)
        {
            //értéket ad az adattagoknak
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;


        }

        public void Ir()
        {
            Console.WriteLine("{0} most ir.", this.nev);
        }

        public void Olvas()
        {
            Console.WriteLine("{0} most olvas", this.nev);
        }
    }

    //leszármazott osztályt hozunk létre
    class Felnottek : Emberek
    {

        //saját adattag
        public string lakhely; 


        public Felnottek(string nev, int kor, string nem):base(nev,kor,nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;

        }

        public Felnottek(string nev, int kor, string nem, string lakhely) : base(nev, kor, nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
            this.lakhely = lakhely;

        }

        public void Beszel()
        {
            Console.WriteLine("{0} most beszél", this.nev);
        }
    }





}
