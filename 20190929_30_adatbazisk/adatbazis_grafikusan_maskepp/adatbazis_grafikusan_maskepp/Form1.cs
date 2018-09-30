using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adatbazis_grafikusan_maskepp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //connection string létrehozása, ez definiálja az adatbázis elérését
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("sikeres kapcsolódás");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "sikertelen kapcsolódás, a számítógép megsemmisíti önmagát");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into Konyv values('C# prog3', 111349, 200, 'Varga Miklós', 'Kiskapu')", conn);

            int hany_sor_erintett = comm.ExecuteNonQuery();
            MessageBox.Show(hany_sor_erintett.ToString() + " sor érintett");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("update Konyv set Oldalszam=Oldalszam+50 where Oldalszam>100", conn);

            int hany_sor_erintett = comm.ExecuteNonQuery();
            MessageBox.Show(hany_sor_erintett.ToString() + " sor érintett");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;

            SqlCommand comm = new SqlCommand("select * from Konyv order by Konyv_cime", conn);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                //oszlopok hozzáadása datagridviewhoz
                //csak akkor adunk hozzá , ha nincs oszlopa
                if (dataGridView1.Columns.Count==0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string oszlopnev = reader.GetName(i).ToLower();
                        dataGridView1.Columns.Add(oszlopnev, oszlopnev);
                    }
                }

                //sorok hozzáadása
                dataGridView1.Rows.Add();
                int sorazon = dataGridView1.Rows.Count-1;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataGridView1.Rows[sorazon].Cells[i].Value = reader[i].ToString();
                }
            }

            reader.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("delete from Konyv where Konyv_cime='C# prog3'", conn);
            int hany_sor_erintett = comm.ExecuteNonQuery();
            MessageBox.Show(hany_sor_erintett.ToString() + " sor érintett");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Konyv order by Konyv_cime", conn);
            SqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {
                listBox1.Items.Add(reader["Konyv_cime"].ToString() + "\t\t "+ reader["Szerzo"].ToString());
            }

            reader.Close();
  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            SqlCommand comm = new SqlCommand("select * from Konyv order by Konyv_cime", conn);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                //hozzáadjuk az oszlopokat
                if (listView1.Columns.Count==0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        listView1.Columns.Add(reader.GetName(i));
                    }
                }

                //ebben tároljuk a mezők értékeit
                string[] data = new string[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[i] = reader.GetValue(i).ToString();
                }

                //új sor hozzáadása listviewhoz -- listview item létrehozása
                listView1.Items.Add(new ListViewItem(data));


            }

            reader.Close();


        }
    }
}
