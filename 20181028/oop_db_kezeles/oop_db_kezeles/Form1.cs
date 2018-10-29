using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; //kell a property info lekérdezéséhez

namespace oop_db_kezeles
{
    public partial class Form1 : Form
    {

        List<Konyv1> konyvek;

        public Form1()
        {
            InitializeComponent();
        }

        //megjelenítés listboxban

        void listbox_megjelenit()
        {
            listBox1.Items.Clear();
            foreach (var item in konyvek)
            {
                listBox1.Items.Add(item.Cim + ";\t" + item.Isbn + ";\t" + item.Oldalszam.ToString() + ";\t" + item.Szerzo + ";\t" + item.Kiado);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //könyvek lista beolvasása
            konyvek = Adatbaziskezelo.Beolvas();
            listbox_megjelenit();
            listview_megjelenit();
            datagridview_megjelenit();
        }

        Konyv1 konyv;

        private void button1_Click(object sender, EventArgs e)
        {
            //a 
            konyv = new Konyv1(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
            Adatbaziskezelo.Uj_bevitel(konyv); //csak adatbázisba viszi be

            konyvek.Add(konyv); //a listánkba is berakja
            listbox_megjelenit();
            listview_megjelenit();
            datagridview_megjelenit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var melyik = konyvek[listBox1.SelectedIndex].Isbn;
            konyv = new Konyv1(textBox1.Text, melyik, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
            Adatbaziskezelo.Modositas(konyv);

            //először a listboxból a régit törölni, és utána az újat hozzáadni!
            konyvek.RemoveAt(listBox1.SelectedIndex);
            konyvek.Add(konyv);
            listbox_megjelenit();
            listview_megjelenit();
            datagridview_megjelenit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //figyelmeztető üzenet - ha van kijelölve ÉS leokézta
            if (listBox1.SelectedIndex>-1 && MessageBox.Show("bizti?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                konyv = konyvek[listBox1.SelectedIndex];
                Adatbaziskezelo.Torles(konyv);
                konyvek.RemoveAt(listBox1.SelectedIndex);
                listbox_megjelenit();
                listview_megjelenit();
                datagridview_megjelenit();
            }
            
        }

        //megjelenítés listviewban
        void listview_megjelenit()
        {
            listView1.View = View.Details;
            listView1.Items.Clear();
            var properties = typeof(Konyv1).GetProperties();

            //oszlopok létrehozása(ha nincsenek)
            if (listView1.Columns.Count==0)
            {
                foreach (var item in properties)
                {
                    listView1.Columns.Add(item.Name); //oszlopnév a property neve lesz
                }
               
            }

            //töltsük fel sorokkal

           

            foreach (var item in konyvek) //egy elem egy sor
            {
                //string vektor a mezők értékeinek tárolásához
                //annyi eleme lesz a stringnek, ahány property van a könyv osztályban
                string[] adatok = new string[properties.Length];
                for (int i = 0; i < adatok.Length; i++)
                {
                    //feltöltjük a mezők értékeivel a vektort
                    adatok[i] = properties[i].GetValue(item).ToString();
                }

                listView1.Items.Add(new ListViewItem(adatok));
            }




        }

        //megjelenítés datagridview-ban
        void datagridview_megjelenit()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            var properties = typeof(Konyv1).GetProperties();

            if (dataGridView1.Columns.Count == 0)
            {
                foreach (var item in properties)
                {
                    dataGridView1.Columns.Add(item.Name, item.Name); //oszlopnév a property neve lesz
                }
            }

            //sorok hozzáadása
            foreach (var item in konyvek)
            {
                dataGridView1.Rows.Add();//üres sor hozzáadása először

                //egy soron belül az oszlopok(mezők) hozzáadása
                for (int i = 0; i < properties.Length; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = properties[i].GetValue(item);
                }
            }
        }
    }
        
}
