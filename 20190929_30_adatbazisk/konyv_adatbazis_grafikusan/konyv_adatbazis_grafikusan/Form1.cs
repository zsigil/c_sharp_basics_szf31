using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyv_adatbazis_grafikusan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void konyvBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.konyvBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Konyv' table. You can move, or remove it, as needed.
            //this.konyvTableAdapter.Fill(this.database1DataSet.Konyv);

        }
        //inicializálás, tábla adatainak betöltése
        private void button1_Click(object sender, EventArgs e)
        {
            //buttonclickhez köti a táblaadatok megjelenítését
            this.konyvTableAdapter.Fill(this.database1DataSet.Konyv);
            MessageBox.Show("A tábla betöltve");

        }
        //új sor hozzáadása (insert)
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow ujsor = database1DataSet.Konyv.NewRow();
            ujsor["Konyv_cime"] = textBox1.Text;
            ujsor["ISBN"] = textBox2.Text;
            ujsor["Oldalszam"] = textBox3.Text;
            ujsor["Szerzo"] = textBox4.Text;
            ujsor["Kiado"] = textBox5.Text;

            database1DataSet.Konyv.Rows.Add(ujsor);

            konyvTableAdapter.Update(database1DataSet.Konyv);
            MessageBox.Show("hurrá");

        }
        //sor (rekord)módosítása
        private void button3_Click(object sender, EventArgs e)
        {
            DataRow sor = database1DataSet.Konyv.Rows[2];
            sor.BeginEdit();
            sor["Konyv_cime"] = "Excel könyv";
            sor.EndEdit();

            konyvTableAdapter.Update(database1DataSet.Konyv);
            MessageBox.Show("hiphiphurrá");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow sor = database1DataSet.Konyv.Rows[2];
            sor.Delete();
            konyvTableAdapter.Update(database1DataSet.Konyv);
            MessageBox.Show("oooóóóóó");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //üres listbox
            listBox1.Items.Clear();
            foreach (var sor in database1DataSet.Konyv.Select("oldalszam>500"))
            {
                listBox1.Items.Add(sor["Konyv_cime"].ToString() + " ," + sor["Oldalszam"].ToString());
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string feltetel1 = textBox6.Text;
            string feltetel2 = textBox7.Text;
            string lekerdez = feltetel1 + feltetel2;

            listBox2.Items.Clear();
            foreach (var sor in database1DataSet.Konyv.Select(lekerdez))
            {
                listBox2.Items.Add(sor["Konyv_cime"]);
            }

        }
        //megjelenítés táblázatosan (dataGridView)
        private void button7_Click(object sender, EventArgs e)
        {
            //visszaállítjuk alaphelyzetbe
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            


            string feltetel1 = textBox6.Text;
            string feltetel2 = textBox7.Text;
            string lekerdez = feltetel1 + feltetel2;

            dataGridView1.DataSource = database1DataSet.Konyv.Select(lekerdez);
        }
    }
}
