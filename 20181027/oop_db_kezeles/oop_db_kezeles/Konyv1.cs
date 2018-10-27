using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_db_kezeles
{
    public class Konyv1
    {
        //private adattagok létrehozása
        string cim;
        string isbn;
        int oldalszam;
        string szerzo;
        string kiado;

        #region //getterek és setterek
        //property
        //speciális metódus a privát adattagok eléréséhez
        public string Cim
        {
            get
            {
                return cim;
            }

            set
            {
                cim = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public int Oldalszam
        {
            get
            {
                return oldalszam;
            }

            set
            {
                oldalszam = value;
            }
        }

        public string Szerzo
        {
            get
            {
                return szerzo;
            }

            set
            {
                szerzo = value;
            }
        }

        public string Kiado
        {
            get
            {
                return kiado;
            }

            set
            {
                kiado = value;
            }
        }
        #endregion 

        //konstruktorok létrehozása

        public Konyv1 (string cim,string isbn,int oldalszam,string szerzo,string kiado)
        {
            Cim = cim;
            Isbn = isbn;
            Oldalszam = oldalszam;
            Szerzo = szerzo;
            Kiado = kiado;

        }

        //ha nincs isbn - ez a primary key, 
        //ezt a konstruktort módosításra fogjuk használni!
        public Konyv1(string cim, int oldalszam, string szerzo, string kiado)
        {
            Cim = cim;
            Oldalszam = oldalszam;
            Szerzo = szerzo;
            Kiado = kiado;
        }
    }

}
