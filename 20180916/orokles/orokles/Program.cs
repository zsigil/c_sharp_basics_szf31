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
            Anna.Olvas();
            Console.WriteLine(Anna);

            //3 példányos konstruktor
            Felnottek Bela = new Felnottek("Béla", 50, "férfi");
            Bela.Ir();
            Bela.Beszel();

            //4 példányos konstruktor
            Felnottek Maris = new Felnottek("Maris", 72, "nő", "Szombathely");
            Console.WriteLine(Maris.lakhely);
            Maris.Olvas();
            Maris.Beszel();
            Console.WriteLine(Maris);

            //emberek típusú, felnőttek 4-es konstruktorral!
            //alapból ősosztály olvas metódusát kapja!
            //ha virtual void jelezve van, akkor megkapja a leszármazott osztályét
            Emberek Attila = new Felnottek("Attila", 45, "férfi", "Vác");

            Console.WriteLine(Attila);
            Attila.Olvas();
            //a lakhelyet nem fogja látni!!
            //Console.WriteLine(Attila.lakhely);



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
            Console.WriteLine("{0} most ir az ősosztályban.", this.nev);
        }

        /*
        //kikényszerített felüldefiniálásnál nem kell jelezni az ősosztályban
        //hogy lesz-e felüldefiniálás ( mert nem tudjuk előre)

        public void Olvas()
        {
            Console.WriteLine("{0} most olvas", this.nev);
        }
        */

        //tervezett felüldefiniálásnál jelezzük előre az ősosztályban
        public virtual void Olvas()
        {
            Console.WriteLine("{0} most olvas az ősosztályban", this.nev);
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

        /*
        //kikényszerített felüldefiniálás
        public void Olvas()
        {
            Console.WriteLine("{0} most felnőttként olvas", this.nev);
        }
        */
        //felüldefiniált osztályt jeleznem kell itt is
        public override void Olvas()
        {
            Console.WriteLine("{0} most felnőttként olvas", this.nev);
        }



    }





}
