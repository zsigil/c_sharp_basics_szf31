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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //ISKOLA

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


        public static List<Iskola> Isk_beolvas_abcben()
        {
            List<Iskola> eredmeny2 = new List<Iskola>();

            try
            {
                string sql = "select * from iskola order by isk_neve";
                comm = new SqlCommand(sql, conn);

                SqlDataReader reader = comm.ExecuteReader();


                //tábla sorainak beolvasása(ha elfogy, false-t dob vissza)
                while (reader.Read())
                {
                    eredmeny2.Add(new Iskola(
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
            return eredmeny2;
        }

        //TANULÓK

        public static List<Tanulo> Tan_beolvas()
        {
            List<Tanulo> eredmeny = new List<Tanulo>();

            try
            {
                string sql = "select * from tanulo";
                comm = new SqlCommand(sql, conn);

                SqlDataReader reader = comm.ExecuteReader();


                //tábla sorainak beolvasása(ha elfogy, false-t dob vissza)
                while (reader.Read())
                {
                    eredmeny.Add(new Tanulo(
                        reader["tan_azon"].ToString(),
                        reader["tan_nev"].ToString(),
                        reader["tan_szul"].ToString(),
                        reader["tan_varos"].ToString(),
                        reader["tan_irszam"].ToString(),
                        reader["tan_utca"].ToString(),
                        reader["tan_anyjaneve"].ToString(),
                        reader["tan_oszt"].ToString(),
                        float.Parse(reader["tan_atlag"].ToString())

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

        public static void Uj_tanulo(Tanulo uj_tanulo)
        {
            try
            {
                //paraméteres sql commandot hozunk létre
                comm = new SqlCommand("insert into [tanulo] ([tan_azon], [tan_nev], [tan_szul], [tan_varos], [tan_irszam], [tan_utca], [tan_anyjaneve], [tan_oszt], [tan_atlag]) values (@azon, @nev, @szul, @varos, @irszam, @utca, @aneve, @oszt, @atlag)", conn);
                comm.Parameters.AddWithValue("@azon", uj_tanulo.Azon);
                comm.Parameters.AddWithValue("@nev", uj_tanulo.Nev);
                comm.Parameters.AddWithValue("@szul", uj_tanulo.Szul);
                comm.Parameters.AddWithValue("@varos", uj_tanulo.Varos);
                comm.Parameters.AddWithValue("@irszam", uj_tanulo.Irszam);
                comm.Parameters.AddWithValue("@utca", uj_tanulo.Utca);
                comm.Parameters.AddWithValue("@aneve", uj_tanulo.Anyjaneve);
                comm.Parameters.AddWithValue("@oszt", uj_tanulo.Osztaly);
                comm.Parameters.AddWithValue("@atlag", uj_tanulo.Atlag);
                comm.ExecuteNonQuery(); // command lefuttatása 
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public static void Modosit_tanulo(Tanulo modositando)
        {

            try
            {
                //paraméteres sql commandot hozunk létre
                comm = new SqlCommand("update [tanulo] set [tan_nev]=@nev, [tan_szul]=@szul, [tan_varos]=@varos, [tan_irszam]=@irszam, [tan_utca]=@utca, [tan_anyjaneve]=@aneve, [tan_oszt]=@oszt, [tan_atlag]=@atlag where [tan_azon]=@azon", conn);
                comm.Parameters.AddWithValue("@azon", modositando.Azon);
                comm.Parameters.AddWithValue("@nev", modositando.Nev);
                comm.Parameters.AddWithValue("@szul", modositando.Szul);
                comm.Parameters.AddWithValue("@varos", modositando.Varos);
                comm.Parameters.AddWithValue("@irszam", modositando.Irszam);
                comm.Parameters.AddWithValue("@utca", modositando.Utca);
                comm.Parameters.AddWithValue("@aneve", modositando.Anyjaneve);
                comm.Parameters.AddWithValue("@oszt", modositando.Osztaly);
                comm.Parameters.AddWithValue("@atlag", modositando.Atlag);
                comm.ExecuteNonQuery(); // command lefuttatása 
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public static void Torol_tanulo(Tanulo torlendo)
        {
            try
            {
                comm = new SqlCommand("delete from [tanulo] where [tan_azon]=@azon", conn);
                comm.Parameters.AddWithValue("@azon", torlendo.Azon);
                comm.ExecuteNonQuery();
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public static List<Tanulo> Tan_beolvas_abcben()
        {
            List<Tanulo> eredmeny3 = new List<Tanulo>();

            try
            {
                string sql = "select * from tanulo order by tan_nev;";
                comm = new SqlCommand(sql, conn);

                SqlDataReader reader = comm.ExecuteReader();


                //tábla sorainak beolvasása(ha elfogy, false-t dob vissza)
                while (reader.Read())
                {
                    eredmeny3.Add(new Tanulo(
                        reader["tan_azon"].ToString(),
                        reader["tan_nev"].ToString(),
                        reader["tan_szul"].ToString(),
                        reader["tan_varos"].ToString(),
                        reader["tan_irszam"].ToString(),
                        reader["tan_utca"].ToString(),
                        reader["tan_anyjaneve"].ToString(),
                        reader["tan_oszt"].ToString(),
                        float.Parse(reader["tan_atlag"].ToString())

                        ));
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return eredmeny3;
        }
    } 
}
