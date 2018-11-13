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
    }
}
