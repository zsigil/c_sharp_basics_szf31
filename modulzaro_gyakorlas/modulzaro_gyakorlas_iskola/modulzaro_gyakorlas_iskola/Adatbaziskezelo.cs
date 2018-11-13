using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace modulzaro_gyakorlas_iskola
{
    public static class Adatbaziskezelo
    {
        static SqlConnection conn;
        static SqlCommand comm;

        static Adatbaziskezelo()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static void kapcs_bezar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static List<Iskola> Isk_beolvas()
        {
            List<Iskola> eredmeny = new List<Iskola>();

            try
            {
                string sql = "select * from iskola";
                comm = new SqlCommand(sql, conn);

                SqlDataReader reader = comm.ExecuteReader();


                //tábla sorainak beolvasása(ha elfogy, false-t dob vissza)
                while (reader.Read())
                {
                    eredmeny.Add(new Iskola(
                        reader["isk_azon"].ToString(),
                        reader["isk_neve"].ToString(),
                        reader["isk_varos"].ToString(),
                        reader["isk_irszam"].ToString(),
                        reader["isk_utca"].ToString(),
                        reader["isk_tel"].ToString()
                        ));
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return eredmeny;
        }

        public static void Uj_iskola(Iskola uj_iskola)
        {
            try
            {
                //paraméteres sql commandot hozunk létre
                comm = new SqlCommand("insert into [Iskola] ([isk_azon], [isk_neve], [isk_varos], [isk_irszam], [isk_utca], [isk_tel]) values (@azon, @nev, @varos, @irszam, @utca, @tel)", conn);
                comm.Parameters.AddWithValue("@azon", uj_iskola.Azon);
                comm.Parameters.AddWithValue("@nev", uj_iskola.Nev);
                comm.Parameters.AddWithValue("@varos", uj_iskola.Varos);
                comm.Parameters.AddWithValue("@irszam", uj_iskola.Irszam);
                comm.Parameters.AddWithValue("@utca", uj_iskola.Utca);
                comm.Parameters.AddWithValue("@tel", uj_iskola.Telszam);
                comm.ExecuteNonQuery(); // command lefuttatása 
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public static void Modosit_iskola(Iskola modositando)
        {
            try
            {
                //paraméteres sql commandot hozunk létre
                comm = new SqlCommand("update [Iskola] set [isk_neve]=@nev, [isk_varos]=@varos, [isk_irszam]=@irszam, [isk_utca]=@utca, [isk_tel]=@tel where [isk_azon]=@azon", conn);
                comm.Parameters.AddWithValue("@azon", modositando.Azon);
                comm.Parameters.AddWithValue("@nev", modositando.Nev);
                comm.Parameters.AddWithValue("@varos", modositando.Varos);
                comm.Parameters.AddWithValue("@irszam", modositando.Irszam);
                comm.Parameters.AddWithValue("@utca", modositando.Utca);
                comm.Parameters.AddWithValue("@tel", modositando.Telszam);
                comm.ExecuteNonQuery(); // command lefuttatása 
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }




    }
}
