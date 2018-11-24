using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro_gyakorlas_orai
{
    public class Iskola
    {
        public int Iskola_azon { get; set; }
        public string Iskola_neve { get; set; }
        public string Iskola_cime { get; set; }
        public string Iskola_telefonszama { get; set; }

        //full konstruktor
        public Iskola(int iskola_azon, string iskola_neve, string iskola_cime, string isk_telszam)
        {
            Iskola_azon = iskola_azon;
            Iskola_neve = iskola_neve;
            Iskola_cime = iskola_cime;
            Iskola_telefonszama = isk_telszam;
        }

        //pk nélkül
        public Iskola(string iskola_neve, string iskola_cime, string isk_telszam)
        {
            Iskola_neve = iskola_neve;
            Iskola_cime = iskola_cime;
            Iskola_telefonszama = isk_telszam;
        }

    }
}
