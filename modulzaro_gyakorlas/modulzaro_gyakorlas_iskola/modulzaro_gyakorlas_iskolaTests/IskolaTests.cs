using Microsoft.VisualStudio.TestTools.UnitTesting;
using modulzaro_gyakorlas_iskola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro_gyakorlas_iskola.Tests
{
    [TestClass()]
    public class IskolaTests
    {
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void iskola_nev_max_50_kar()
        {
            Iskola uj_iskola = new Iskola("asc", "01234567890123456789012345678901234567890123456789a", "bp", "1234", "rigó u3", "12311");

        }


    }

}