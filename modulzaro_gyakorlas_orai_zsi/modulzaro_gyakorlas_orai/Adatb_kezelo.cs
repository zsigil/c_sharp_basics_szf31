using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace modulzaro_gyakorlas_orai
{
    public static class Adatb_kezelo
    {
        static SqlConnection conn;
        static SqlCommand comm;

        static Adatb_kezelo()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

            conn.Open();
        }

        //statikus metódus iskola tábla beolvasásához
        public static List<Iskola> Beolvas_iskola()
        {
            List<Iskola> eredmeny = new List<Iskola>();
            string sql_utasitas = "select * from iskola";
            comm = new SqlCommand(sql_utasitas, conn);

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                eredmeny.Add(new Iskola(
                    int.Parse(reader["iskola_id"].ToString()),
                    reader["iskola_neve"].ToString(),
                    reader["iskola_cime"].ToString(),
                    reader["iskola_telefonszama"].ToString()
                    ));
            }
            reader.Close();
            return eredmeny;
        }

        public static List<Tanulo> Beolvas_tanulo()
        {
            List<Tanulo> eredmeny2 = new List<Tanulo>();
            string sql_utasitas = "select * from tanulo";
            comm = new SqlCommand(sql_utasitas, conn);

            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                eredmeny2.Add(new Tanulo(
                    int.Parse(reader["tanulo_id"].ToString()),
                    reader["tanulo_neve"].ToString(),
                    reader["tanulo_szul_datum"].ToString(),
                    reader["tanulo_cime"].ToString(),
                    reader["tanulo_anyja_neve"].ToString(),
                    reader["tanulo_osztaly"].ToString(),
                    double.Parse(reader["tanulo_atlaga"].ToString()),
                    int.Parse(reader["iskola_azon"].ToString())

                    ));
            }
            reader.Close();
            return eredmeny2;
        }

        public static void Uj_iskola_bevitel(Iskola uj_iskola)
        {
            string sql_ut = "insert into iskola (iskola_id, iskola_neve, iskola_cime, iskola_telefonszama) values (@iskola_id, @iskola_neve, @iskola_cime, @iskola_telefonszama)";
            comm = new SqlCommand(sql_ut, conn);
            comm.Parameters.AddWithValue("@iskola_id", uj_iskola.Iskola_azon);
            comm.Parameters.AddWithValue("@iskola_neve", uj_iskola.Iskola_neve);
            comm.Parameters.AddWithValue("@iskola_cime", uj_iskola.Iskola_cime);
            comm.Parameters.AddWithValue("@iskola_telefonszama", uj_iskola.Iskola_telefonszama);
            comm.ExecuteNonQuery();
        }

        public static void Iskola_modositas(Iskola modositando)
        {
            string sql_ut = "update iskola set iskola_neve=@iskola_neve, iskola_cime=@iskola_cime, iskola_telefonszama=@isk_tel where iskola_id=@iskola_id";
            comm = new SqlCommand(sql_ut, conn);
            comm.Parameters.AddWithValue("@iskola_id", modositando.Iskola_azon);
            comm.Parameters.AddWithValue("@iskola_neve", modositando.Iskola_neve);
            comm.Parameters.AddWithValue("@iskola_cime", modositando.Iskola_cime);
            comm.Parameters.AddWithValue("@isk_tel", modositando.Iskola_telefonszama);
            comm.ExecuteNonQuery();
        }

        public static void Iskola_torles(Iskola torlendo)
        {
            comm = new SqlCommand("delete from iskola where iskola_id=@azon", conn);
            comm.Parameters.AddWithValue("@azon", torlendo.Iskola_azon);
            comm.ExecuteNonQuery();
        }


    }
}
