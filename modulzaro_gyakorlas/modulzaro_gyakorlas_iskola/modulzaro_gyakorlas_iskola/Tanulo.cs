using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro_gyakorlas_iskola
{
    class Tanulo
    {
        string azon;
        string nev;
        string szul;
        string varos;
        string irszam;
        string utca;
        string anyjaneve;
        string osztaly;
        float atlag;

        public string Azon
        {
            get
            {
                return azon;
            }
            set
            {
                if (azon == null)
                {
                    azon = value;
                }
                else
                {
                    throw new InvalidOperationException("ilyen isbn már volt");
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

        public string Szul
        {
            get
            {
                return szul;
            }
            set
            {
                szul = value;
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
                irszam= value;
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

        public string Anyjaneve
        {
            get
            {
                return anyjaneve;
            }
            set
            {
                anyjaneve = value;
            }
        }

        public string Osztaly
        {
            get
            {
                return osztaly;
            }
            set
            {
                osztaly = value;
            }
        }

        public float Atlag
        {
            get
            {
                return atlag;
            }
            set
            {
                atlag = value;
            }
        }

        public Tanulo(string azon, string nev, string szul, string varos, string irszam, string utca, string anyjaneve, string osztaly, float atlag)
        {
            Azon = azon;
            Nev = nev;
            Szul = szul;
            Varos = varos;
            Irszam = irszam;
            Utca = utca;
            Anyjaneve = anyjaneve;
            Osztaly = osztaly;
            Atlag = atlag;
        }

        public Tanulo(string nev, string szul, string varos, string irszam, string utca, string anyjaneve, string osztaly, float atlag)
        {
            Nev = nev;
            Szul = szul;
            Varos = varos;
            Irszam = irszam;
            Utca = utca;
            Anyjaneve = anyjaneve;
            Osztaly = osztaly;
            Atlag = atlag;
        }
    }
}
