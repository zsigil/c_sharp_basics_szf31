using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modulzaro_pelda12011A
{
    static class Adatb_kezelo
    {
        //statikus adattagok
        static SqlConnection conn;
        static SqlCommand comm;
        
        //statikus konstruktorral hozzuk létre a kapcsolatot

        static Adatb_kezelo()
        {
            try
            {                
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                conn.Open();
            }

            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült csatlakozni!");
            }
        }

        //statikus metódus a kapcsolat lezárására
        public static void Kapcs_bezar()
        {
            try
            {
                conn.Close();
            }

            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message);
            }
        }

        //statikus metódus a vevo tábla beolvasásához
        public static List<Vevo> Beolvas()
        {
            List<Vevo> eredmeny = new List<Vevo>();
            try
            {                
                string sql = "SELECT * FROM [Vevo]";
                comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    eredmeny.Add(new Vevo(
                        (int)reader["vevo_id"], 
                        reader["vevo_nev"].ToString(),
                       (int)reader["irsz"],
                        reader["varos"].ToString(),
                        reader["utca"].ToString(),
                        (int)reader["hsz"],
                        reader["tel"].ToString()));
                }
                reader.Close();
                
            }

            
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült a beolvasás!");
            }
            return eredmeny;
        }

        //statikus metódus az új vevő rögzítéséhez
        public static void Uj_Bevitel(Vevo uj_vevo)
        {
            if (uj_vevo == null) throw new NullReferenceException("Nem megfelelő objektum!");
            try
            {
                comm = new SqlCommand("INSERT INTO [Vevo] ([vevo_id], [vevo_nev], [irsz], [varos], [utca], [hsz], [tel]) VALUES (@id, @nev, @irsz, @varos, @utca, @hsz, @tel)", conn);
                //Paraméterek megadása
                comm.Parameters.AddWithValue("@id", uj_vevo.Vevo_ID);
                comm.Parameters.AddWithValue("@nev", uj_vevo.Vevo_Nev);
                comm.Parameters.AddWithValue("@irsz", uj_vevo.Irsz);
                comm.Parameters.AddWithValue("@varos", uj_vevo.Varos);
                comm.Parameters.AddWithValue("@utca", uj_vevo.Varos);
                comm.Parameters.AddWithValue("@hsz", uj_vevo.Hsz);
                comm.Parameters.AddWithValue("@tel", uj_vevo.Tel);
                comm.ExecuteNonQuery(); //a command futtatása

            }

            catch (SqlException kiv)
            {
                MessageBox.Show("Hiba a lekérdezés során! " + kiv.Message);
            }
            catch (NullReferenceException kiv)
            {
                MessageBox.Show(kiv.Message);

            }
        }
        
        //statikus metódus a vevő módosításhoz
        public static void Modositas(Vevo modositando)
        {
            
            try
            {
                //Paraméteres commandot hozunk létre
                comm = new SqlCommand("UPDATE [Vevo] SET [vevo_nev]=@nev, [irsz]=@irsz, [varos]=@varos, [utca]=@utca, [hsz]=@hsz, [tel]=@tel WHERE [vevo_id]=@vevo_id", conn);
                comm.Parameters.AddWithValue("@vevo_id", modositando.Vevo_ID);
                comm.Parameters.AddWithValue("@nev", modositando.Vevo_Nev);
                comm.Parameters.AddWithValue("@irsz", modositando.Irsz);
                comm.Parameters.AddWithValue("@varos", modositando.Varos);
                comm.Parameters.AddWithValue("@utca", modositando.Varos);
                comm.Parameters.AddWithValue("@hsz", modositando.Hsz);
                comm.Parameters.AddWithValue("@tel", modositando.Tel);
                comm.ExecuteNonQuery(); //a command futtatása
            }
            catch (SqlException kiv)
            {
                MessageBox.Show(kiv.Message);
            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message);
            }
        }
        
        //statikus metódus a vevő törléshez
        public static void Torles(Vevo torolendo)
        {
            try
            {
                comm = new SqlCommand("DELETE FROM [Vevo] WHERE [vevo_id] = @id", conn);
                comm.Parameters.AddWithValue("@id", torolendo.Vevo_ID);
                comm.ExecuteNonQuery();
            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message);
            }
        }

        //statikus metódus egy vevő kereséséhez
        public static List<Vevo> Keres(Vevo egy_vevo)
        {
            List<Vevo> eredmeny = new List<Vevo>();
            try
            {
                string sql = "SELECT * FROM [Vevo] WHERE [vevo_nev] = @nev";
                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@nev", egy_vevo.Vevo_Nev);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    eredmeny.Add(new Vevo(
                        (int)reader["vevo_id"],
                        reader["vevo_nev"].ToString(),
                       (int)reader["irsz"],
                        reader["varos"].ToString(),
                        reader["utca"].ToString(),
                        (int)reader["hsz"],
                        reader["tel"].ToString()));
                }
                reader.Close();            
            }

            
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült a beolvasás!");
            }
            return eredmeny;
        }

        //statikus metódus a rendeles tábla beolvasásához
        public static List<Rendeles> Beolvas_rendeles()
        {
            List<Rendeles> eredmeny = new List<Rendeles>();
            try
            {
                string sql = "SELECT * FROM [Rendeles] order by rendeles_id asc";
                comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    eredmeny.Add(new Rendeles(
                        (int)reader["rendeles_id"],
                        (int)reader["v_id"],
                       (int)reader["p_id"],
                        (int)reader["mennyiseg"],
                        (DateTime)reader["datum"],
                        (int)reader["ido"]
                        ));
                }
                reader.Close();

            }

            
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült a beolvasás!");
            }
            return eredmeny;
        }

        //statikus metódus az új rendeles rögzítéséhez
        public static void Uj_rendelesBevitel(Rendeles uj_rendeles)
        {
            if (uj_rendeles == null) throw new NullReferenceException("Nem megfelelő objektum!");
            try
            {
                comm = new SqlCommand("INSERT INTO [Rendeles] ([rendeles_id], [v_id], [p_id], [mennyiseg], [datum], [ido]) VALUES (@id, @v_id, @p_id, @mennyiseg, @datum, @ido)", conn);
                //Paraméterek megadása
                comm.Parameters.AddWithValue("@id", uj_rendeles.Rendeles_ID);
                comm.Parameters.AddWithValue("@v_id", uj_rendeles.V_id);
                comm.Parameters.AddWithValue("@p_id", uj_rendeles.P_id);
                comm.Parameters.AddWithValue("@mennyiseg", uj_rendeles.Mennyiseg);
                comm.Parameters.AddWithValue("@datum", uj_rendeles.Datum);
                comm.Parameters.AddWithValue("@ido", uj_rendeles.Ido);
                
                comm.ExecuteNonQuery(); //a command futtatása

            }

            catch (SqlException kiv)
            {
                MessageBox.Show("Hiba a lekérdezés során! " + kiv.Message);
            }
            catch (NullReferenceException kiv)
            {
                MessageBox.Show(kiv.Message);

            }
        }

        //statikus metódus a rendelés módosításhoz
        public static void RendelesModositas(Rendeles modositando)
        {            
            try
            {
                //Paraméteres commandot hozunk létre
                comm = new SqlCommand("UPDATE [Rendeles] SET [v_id]=@v_id, [p_id]=@p_id, [mennyiseg]=@mennyiseg, [datum]=@datum, [ido]=@ido WHERE [rendeles_id]=@id", conn);
                comm.Parameters.AddWithValue("@id", modositando.Rendeles_ID);
                comm.Parameters.AddWithValue("@v_id", modositando.V_id);
                comm.Parameters.AddWithValue("@p_id", modositando.P_id);
                comm.Parameters.AddWithValue("@mennyiseg", modositando.Mennyiseg);
                comm.Parameters.AddWithValue("@datum", modositando.Datum);
                comm.Parameters.AddWithValue("@ido", modositando.Ido);
                comm.ExecuteNonQuery(); //a command futtatása
            }
            catch (SqlException kiv)
            {
                MessageBox.Show(kiv.Message);
            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message);
            }
        }

        //statikus metódus egy rendelés kereséséhez
        public static List<Rendeles> RendelesKeres(Rendeles egy_rendeles)
        {
            List<Rendeles> eredmeny = new List<Rendeles>();
            try
            {
                string sql = "SELECT * FROM [Rendeles] WHERE [rendeles_id] = @id";
                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", egy_rendeles.Rendeles_ID);
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    eredmeny.Add(new Rendeles(
                        (int)reader["rendeles_id"],
                        (int)reader["v_id"],
                       (int)reader["p_id"],
                        (int)reader["mennyiseg"],
                        (DateTime)reader["datum"],
                        (int)reader["ido"]
                        ));
                }
                reader.Close();
            }
                        
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült a beolvasás!");
            }
            return eredmeny;
        }

        //statikus metódus a vevők és a pizzák kereséséhez
        public static List<VevokPizza> Vevo_Pizza()
        {
            List<VevokPizza> eredmeny = new List<VevokPizza>();
            try
            {
                string sql = "SELECT * FROM Vevo inner join(Rendeles inner join Pizza on Rendeles.p_id=Pizza.pizza_id) on vevo.vevo_id = Rendeles.v_id";
                comm = new SqlCommand(sql, conn);
                
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    eredmeny.Add(new VevokPizza(
                        reader["vevo_nev"].ToString(),
                        reader["pizza_nev"].ToString()                       
                        ));
                }
                reader.Close();
            }

            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült a beolvasás!");
            }
            return eredmeny;
        }

        //statikus metódus a pizzák megszámolásához
        public static int Pizzakszama()
        {
            int db = 0;
            try
            {
                string sql = "SELECT * FROM [Pizza]";
                comm = new SqlCommand(sql, conn);
                
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    db++;
                }
                reader.Close();
            }

            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Nem sikerült a beolvasás!");
            }
            return db;
        }
    }
}
