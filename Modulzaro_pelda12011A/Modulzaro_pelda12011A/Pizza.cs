using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro_pelda12011A
{
    public class Pizza
    {
        string pizza_nev;
        public string Pizza_nev
        {
            get
            {
                return pizza_nev;
            }

            set
            {
                if (value.Length <= 20)
                {
                    pizza_nev = value;
                }

                else
                {
                    throw new ArgumentException("A pizza neve nem lehet hosszabb mint húsz karakter!");
                }

            }
        }
        public int Pizza_ID { get; set; }
        public int Pizza_Ar { get; set; }
        public int Pizza_Meret { get; set; }

        public Pizza(string nev, int id, int ar, int meret)
        {
            Pizza_nev = nev;
            Pizza_ID = id;
            Pizza_Ar = ar;
            Pizza_Meret = meret;
        }


    }
}
