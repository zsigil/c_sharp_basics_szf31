using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modulzaro_pelda12011A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro_pelda12011A.Tests
{
    [TestClass()]
    public class PizzaTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PizzaTest()
        {
            Pizza uj_pizza = new Pizza("valami", 8, 100, 20);
            uj_pizza.Pizza_nev = "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq";
        }
    }
}