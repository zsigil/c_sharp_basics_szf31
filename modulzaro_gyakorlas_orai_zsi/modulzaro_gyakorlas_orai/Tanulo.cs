using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro_gyakorlas_orai
{
    public class Tanulo
    {
        public int Tanulo_azon { get; set; }
        public string Tanulo_neve { get; set; }
        public string Tanulo_szul_datum { get; set; }
        public string Tanulo_lakcime { get; set; }
        public string Tanulo_anyja_neve { get; set; }
        public string Tanulo_osztalya { get; set; }
        public double Tanulo_atlaga { get; set; }
        public int Iskola_ID { get; set; }

        public Tanulo(int azon, string nev, string szul, string cim, string anyja, string oszt, double atlag, int iskazon)
        {
            Tanulo_azon = azon;
            Tanulo_neve = nev;
            Tanulo_szul_datum = szul;
            Tanulo_lakcime = cim;
            Tanulo_anyja_neve = anyja;
            Tanulo_osztalya = oszt;
            Tanulo_atlaga = atlag;
            Iskola_ID = iskazon;

        }

        public Tanulo(string nev, string szul, string cim, string anyja, string oszt, double atlag, int iskazon)
        {
            Tanulo_neve = nev;
            Tanulo_szul_datum = szul;
            Tanulo_lakcime = cim;
            Tanulo_anyja_neve = anyja;
            Tanulo_osztalya = oszt;
            Tanulo_atlaga = atlag;
            Iskola_ID = iskazon;

        }
    }


}
