using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"C:\teszt2\"; //mappa elérési útvonala
            string filePath = dirPath + "file.txt"; //file elérési útja

            //mappa létezik -e, ha nem létezik, hozzuk létre
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            //FileInfo típusú objektum létrehozása
            //hogy lássuk, van-e már ilyen fájl
            
            FileInfo fi = new FileInfo(filePath);
            if (!fi.Exists)
            {
                StreamWriter sw = fi.CreateText();
                sw.WriteLine("Zsigmond");
                sw.WriteLine("Ildiko");
                sw.Close();
            }
            else
            {
                Console.WriteLine("a file már létezik");

            }

           

            Console.ReadLine();
        }
    }
}
