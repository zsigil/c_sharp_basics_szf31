using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro_pelda12011A
{
    class Rendeles
    {
        public int Rendeles_ID { get; set; }
        public int V_id { get; set; }
        public int P_id { get; set; }
        public int Mennyiseg { get; set; }
        public DateTime Datum { get; set; }
        public int Ido { get; set; }

        public Rendeles(int rend_id, int v_id, int p_id, int mennyiseg, DateTime datum, int ido)
        {
            Rendeles_ID = rend_id;
            V_id = v_id;
            P_id = p_id;
            Mennyiseg = mennyiseg;
            Datum = datum;
            Ido = ido;
        }
    }
}
