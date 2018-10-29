using Microsoft.VisualStudio.TestTools.UnitTesting;
using szamitasok_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamitasok_BL.Tests
{
    [TestClass()]
    public class KorTests
    {
        [TestMethod()]
        public void TeruletTest()
        {
            double r = 10;
            var uj_kor = new Kor(); //kör példány létrehozása
            uj_kor.sugar = r;

            double szamitott_ertek = uj_kor.Terulet();
            double elvart_ertek = 314.15;

            Assert.AreEqual(szamitott_ertek, elvart_ertek, 0.1);

        }

        [TestMethod()]
        public void KeruletTest()
        {
            double r = 10;
            var uj_kor = new Kor(); //kör példány létrehozása
            uj_kor.sugar = r;

            double szamitott_ertek = uj_kor.Kerulet();
            double elvart_ertek = 62.83;

            Assert.AreEqual(szamitott_ertek, elvart_ertek, 0.01);

        }
    }
}