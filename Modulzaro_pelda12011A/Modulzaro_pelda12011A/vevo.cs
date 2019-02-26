using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro_pelda12011A
{
    class Vevo
    {
        //propertyk
        public int Vevo_ID { get; set; }
        public string Vevo_Nev { get; set; }
        public int Irsz { get; set; }
        public string Varos { get; set; }
        public string Utca { get; set; }
        public int Hsz { get; set; }
        public string Tel { get; set; }

        //konstruktor
        public Vevo(int id, string nev, int irsz, string varos, string utca, int hsz, string tel)
        {
            Vevo_ID = id;
            Vevo_Nev = nev;
            Irsz = irsz;
            Varos = varos;
            Utca = utca;
            Hsz = hsz;
            Tel = tel;
        }
    }
}
