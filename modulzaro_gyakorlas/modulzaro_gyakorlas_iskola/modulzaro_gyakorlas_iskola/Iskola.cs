using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro_gyakorlas_iskola
{
    class Iskola
    {
        //privát adattagok
        string azon;
        string nev;
        string varos;
        string irszam;
        string utca;
        string telszam;

        //getterek, és setterek
        public string Azon
        {
            get
            {
                return azon;
            }
            set
            {
                if (azon==null)
                {
                    azon = value;
                }
                else
                {
                    throw new InvalidOperationException("ilyen azonosító már volt");
                }
            }
        }

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                nev = value;
            }
        }

        public string Varos
        {
            get
            {
                return varos;
            }
            set
            {
                varos = value;
            }
        }

        public string Irszam
        {
            get
            {
                return irszam;
            }
            set
            {
                irszam = value;
            }
        }

        public string Utca
        {
            get
            {
                return utca;
            }
            set
            {
                utca = value;
            }
        }

        public string Telszam
        {
            get
            {
                return telszam;
            }
            set
            {
                telszam = value;
            }
        }

        //konstruktorok létrehozása

        public Iskola(string azon, string nev, string varos, string irszam, string utca, string telszam)
        {
            Azon = azon;
            Nev = nev;
            Varos = varos;
            Irszam = irszam;
            Utca = utca;
            Telszam = telszam;
        }

        public Iskola(string nev, string varos, string irszam, string utca, string telszam)
        {
            Nev = nev;
            Varos = varos;
            Irszam = irszam;
            Utca = utca;
            Telszam = telszam;
        }
    }
}
