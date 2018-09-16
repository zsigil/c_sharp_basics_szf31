using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacek
{
    //egy sablont, felületet lehet megadni vele
    //nem példányosítható
    //lehet belőle leszármaztatni
    //őmaga nem osztály, csak osztályszerűen viselkedik
    //c#ban csak egyszeres öröklés van (osztályoknál)
    //egy leszármazott osztály több interfésztől is "származhat",
    //így kvázi többszörös öröklés jöhet létre

    interface IJarmu
    {
        //metódusnak nem lehet törzse
        //az őt megvalósító osztályban meg kell valósítani
        void Megy();

    }


    interface IJarmu1
    {
        void Nem_megy();
    }

    //interface származhat interfésztől
    //nem kell kötelezően megvalósítania azt, amit a szülő tartalmaz 
    interface IJarmu2 : IJarmu
    {
        void Szaguld();
    }


    //leszármaztatjuk az osztályt az interfaceből
    //=megvalósítja ezt a két interfészt
    //az összes metódust meg kell valósítani


    class Auto : IJarmu, IJarmu1
    {
        public void Megy()
        {
            Console.WriteLine("az auto megy...");
        }

        public void Nem_megy()
        {
            Console.WriteLine("az autó nem megy");
        }
    }

    //az Auto osztály teljes értékű osztály, 
    //annak ellenére, h interface-ektől származik
    class kisAuto : Auto
    {

    }

    //az összes "ős" metódusát meg kell valósítani!
    class Hajo : IJarmu2
    {
        public void Megy()
        {
            Console.WriteLine("hajó vagyok");
        }

        public void Szaguld()
        {
            Console.WriteLine("motorcsónakoskodom");
        }
    }

 


    class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto();
            bmw.Megy();
            bmw.Nem_megy();

            kisAuto suzuki = new kisAuto();
            suzuki.Megy();

            Hajo szarnyashajo = new Hajo();
            szarnyashajo.Megy();
            szarnyashajo.Szaguld();


            Console.ReadLine();
        }
    }
}
