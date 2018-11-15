using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iras_txtbe
{
    public class Class1
    {
        public static void txtbe_irom(string mypath, string myliststring)
        {

            FileStream fs2 = new FileStream(mypath, FileMode.Create, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(fs2);


            sw2.Write(myliststring);
            sw2.Write(Environment.NewLine);


            sw2.Close();
            fs2.Close();

        }
    }
}
