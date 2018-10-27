using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        Konyv1 konyv;

        private void button1_Click(object sender, EventArgs e)
        {
            //a 
            konyv = new Konyv1(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
            Adatbaziskezelo.Uj_bevitel(konyv); //csak adatbázisba viszi be

            konyvek.Add(konyv); //a listánkba is berakja
            listbox_megjelenit();

        }
    }
}
