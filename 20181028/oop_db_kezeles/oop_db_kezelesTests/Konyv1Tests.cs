using Microsoft.VisualStudio.TestTools.UnitTesting;
using oop_db_kezeles;  // tesztelt projekt névtere(automatikus)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_db_kezeles.Tests
{
    //teszt osztály(rész, blokk), kötelező 
    //(automatikusan jött létre a create unittesttel!

    [TestClass()] 
    public class Konyv1Tests
    {

        //teszt metódus mindig void, és nem lehetnek paraméterei

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]  //azt várjuk, h exceptiont fog dobni
        public void kiado_max20_karakter()
        {
            //gyakori felépítés: AAA
            // Arrange: teszteléshez szükséges objektumok létrehozása

            // Act: a tesztelendő egyetlen lépés végrehajtása
            // Assert: eredmény/kiértékelés

            //példányosítunk egy objektumot a teszteléshez
            Konyv1 uj_konyv = new Konyv1("proba", "isbn", 3, "akárki", "valami1valami1valami1valami1valami1");

            //uj_konyv.Kiado = "valami1valami1valami1valami1valami1";

        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void isbn_modositas()
        {
            //csak azt ellenőrizzük, h egy adott könyvnek lehet-e módosítani az exception
            Konyv1 uj_konyv = new Konyv1("proba", "isbn", 3, "akárki", "valami1");
            //Konyv1 uj_konyv = new Konyv1("proba", "isbn", 3, "akárki", "valami1");
            uj_konyv.Isbn = "mnvmnv";
        }
    }
}