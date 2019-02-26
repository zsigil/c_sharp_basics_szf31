using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV_iras
{
    public static class Class1
    {
        public static void csv (string sor)
        {
            StreamWriter sw = new StreamWriter("Rendeles_tabla.csv", true, Encoding.UTF8);
            sw.WriteLine(sor);
            sw.Close();
        }
    }
}
