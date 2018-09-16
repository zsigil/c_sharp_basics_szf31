using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_lezart
{
    #region ABSZTRAKT OSZTÁLY
    //absztrakt osztály
    //nem példányosítható, közös őst biztosít a leszármazottaknak
    //gyakorlatilag egy sablon

    abstract class Jarmu
    {
        //csak azt mondja meg , milyen metódusokat kell kötelezően 
        //megvalósítania a leszármazott osztálynak
        //az absztrakt metódusnak nem lehet törzse
        //látszólag nem virtuális, de valójában az
        abstract public void Megy();

    }

    class Auto : Jarmu
    {
        public override void Megy()
        {
            Console.WriteLine("az autó gurul...");
        }

    }

    class Repulo : Jarmu
    {
        public override void Megy()
        {
            Console.WriteLine("a repülő száll...");
        }
    }
    #endregion

    #region LEZÁRT OSZTÁLY
    //lezárt osztályok és metódusok
    //nem lehet belőle további leszármazott osztályt csinálni
    //metódusai nem írhatók felül

    sealed class Motor : Jarmu
    {
        public sealed override void Megy()
        {
            Console.WriteLine("a motor száguldozik...");
        }
    }

    /*
     * NEM FOGADJA EL!
    class Kismotor : Motor
    {
        public void Megy()
        {
            Console.WriteLine("a kismotor is száguldozik...");
        }
    }
    */
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            //absztrakt osztály
            //csak a leszármazott osztály példányosítható
            Auto merci = new Auto();
            merci.Megy();

            Repulo boeing = new Repulo();
            boeing.Megy();



            //lezárt osztály: példányosítható, csak nem örököltethető
            Motor m = new Motor();
            m.Megy();

            Console.ReadLine();
        }
    }


}
