using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter_setter
{
    class Program
    {
        static void Main(string[] args)
        {

            Datum uj_honap = new Datum()
            {
                //ha 15-öt adok meg, set feltétele nem teljesül, marad 7-nek!
                Honap = 10,
                Nap = 20
            };


            Console.WriteLine("hónap1 hónapja: "+ uj_honap.Honap);
            Console.WriteLine("hónap1 nap:"+ uj_honap.Nap);


            uj_honap.Honap = 8;

            Console.WriteLine("honap1: " + uj_honap.Honap);

            //új dátum esetén 
            Datum uj_honap2 = new Datum();

            Console.WriteLine("hónap2: " + uj_honap2.Honap);
            Console.ReadLine();
        }
    }

    //property
    public class Datum
    {
        //adattag -- alapból privát, kívülről nem látszik, csak az osztályon belül
        //adatrejtés elve

        int honap = 7;
        int nap = 30;

        public int Nap { get; set; }

        //property-ken keresztül a privát adattag is elérhető, módosítható
        //a property speciális metódus
        // ha csak get van, akkor csak olvasható
        // ha csak set van, akkor csak írható

        public int Honap
        {
            //érték lekérdezése
            get
            {
                return honap;
            }

            //érték megadása
            set
            {
                if (value>0 && value<13)
                {
                    //value : "láthatatlan paraméter",
                    // ez tartalmazza az adattag új értékét
                    honap = value;
                }

            }
        }

    }


}
