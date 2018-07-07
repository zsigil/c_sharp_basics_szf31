using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterek_atadasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            //érték szerinti paraméter átadás:
            // a változók értéke kerül átadásra a hívó programból az alprogramnak 
            // az alprogramban használt paraméterek és az eredeti változók függetlenek egymástól
            ertek_szerint(a, b); //aktuális paraméterek

            Console.WriteLine(a); //5
            Console.WriteLine(b); //6


            Console.WriteLine("-----------------------------------------------------------------");
            //cím szerinti paraméter átadás
            //a hívó program változóinak memóriacíme kerül átadásra az alprogramnak 
            //az alprogram így módosíthatja az eredeti változók értékét
            cim_szerint(ref a, ref b);
            Console.WriteLine(a); //10
            Console.WriteLine(b); //15



            Console.ReadLine();
        }//main vége

        //akár c éd d is lehetne, tök mindegy, csak utána így kell hivatkozni rá az alprogramban
        static void ertek_szerint(int a, int b)
        {
            //érték szerinti paraméterátadásnál az eredeti változók értéke nem változik,
            //akkor sem, ha az alprogramban megváltoztattuk a paraméterek értékét
            a = 10;
            b = 15;
            Console.WriteLine(a); //10
            Console.WriteLine(b); //15

        }

        //érték típus: pl. numerikus : érték kerül átadásra alapesetben
        //referencia típus: vektor : címe kerül átadásra alapesetben
        static void cim_szerint(ref int a, ref int b)
        {
            a = 10;
            b = 15;

            //az eredeti változók értéke is változik, ha alprogramban megváltoztatom
            Console.WriteLine(a); //10
            Console.WriteLine(b); //15
        }
    }

}
