using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //kell az SQL műveletekhez!!!!!!
using System.Windows.Forms; // grafikus felülethez, pl messagebox

namespace oop_db_kezeles
{
    public static class Adatbaziskezelo
    {
        //statikus adattagok
        static SqlConnection conn;  //kapcsolat
        static SqlCommand comm; //sql utasítás

        //statikus konstruktor - beállítja az adattagokat, nem példányosít
        //nincs láthatósága, nincsenek paraméterei
        //ezzel hozzuk létre a kapcsolatot

        static Adatbaziskezelo()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
               
            }
   
        }

        public static void Kapcs_bezar()
        {
            try
            {
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        #region // alapvető műveletekhez metódusok

        //statikus metódus tábla beolvasásához
        public static List<Konyv1> Beolvas(int sorok_szama = -1)
        {
            //új üres lista létrehozása
            List<Konyv1> eredmeny = new List<Konyv1>();


            try
            {
                //utasítást tartalmazó string
                //string sql = "select * from Konyv";
                string sql = "select " + ((sorok_szama>0) ? $"TOP({ sorok_szama})" : "") + "* from Konyv";

                //utasítás
                comm = new SqlCommand(sql, conn);

                SqlDataReader reader = comm.ExecuteReader();


                //tábla sorainak beolvasása(ha elfogy, false-t dob vissza)
                while (reader.Read())
                {
                    eredmeny.Add(new Konyv1(
                        reader["konyv_cime"].ToString(),
                        reader["ISBN"].ToString(),
                        (int)reader["Oldalszam"],
                        reader["Szerzo"].ToString(),
                        reader["Kiado"].ToString()
                        ));
                }

                reader.Close();
                return eredmeny;
            }
            catch (Exception kiv)
            {

                MessageBox.Show(kiv.Message);
                return eredmeny;
            }

        }


        //statikus metódus az új könyv beviteléhez
        public static void Uj_bevitel(Konyv1 uj_konyv)
        {
            try
            {
                //paraméteres sql commandot hozunk létre
                comm = new SqlCommand("insert into [Konyv] ([Konyv_cime], [ISBN], [Oldalszam], [Szerzo], [Kiado]) values (@cim, @isbn, @oldalszam, @szerzo, @kiado)", conn);
                comm.Parameters.AddWithValue("@cim", uj_konyv.Cim);
                comm.Parameters.AddWithValue("@isbn", uj_konyv.Isbn);
                comm.Parameters.AddWithValue("@oldalszam", uj_konyv.Oldalszam);
                comm.Parameters.AddWithValue("@szerzo", uj_konyv.Szerzo);
                comm.Parameters.AddWithValue("@kiado", uj_konyv.Kiado);
                comm.ExecuteNonQuery(); // command lefuttatása 
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        #endregion
    }
}
