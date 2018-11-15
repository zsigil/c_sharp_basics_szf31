using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iskolak_csvbe
{
    public class Class1
    {
        public static void csvbe_irom(string mypath, string myliststring)
        {

            FileStream fs3 = new FileStream(mypath, FileMode.Create, FileAccess.Write);
            StreamWriter sw3 = new StreamWriter(fs3, Encoding.UTF8);


            sw3.Write(myliststring);
            sw3.Write(Environment.NewLine);


            sw3.Close();
            fs3.Close();

        }
    }
}
