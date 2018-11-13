using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modulzaro_gyakorlas_iskola
{
    public partial class Form1 : Form
    {
        // létrehozzuk őket, hogy tudjuk használni később
        List<Iskola> iskolak;
        List<Tanulo> tanulok;
        Iskola iskola;

        public Form1()
        {
            InitializeComponent();
        }

        void listview_megjelenit_iskola()
        {
            listView1.View = View.Details;
            listView1.Items.Clear();
            var properties = typeof(Iskola).GetProperties();

            //oszlopok létrehozása(ha nincsenek)
            if (listView1.Columns.Count == 0)
            {
                foreach (var item in properties)
                {
                    listView1.Columns.Add(item.Name); //oszlopnév a property neve lesz
                }

            }

            //töltsük fel sorokkal



            foreach (var item in iskolak) //egy elem egy sor
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

        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //új iskola létrehozása
 
            iskola = new Iskola(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            Adatbaziskezelo.Uj_iskola(iskola); //csak adatbázisba viszi be

            iskolak.Add(iskola); //a listánkba is berakja
            listview_megjelenit_iskola();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iskolak = Adatbaziskezelo.Isk_beolvas();
            listview_megjelenit_iskola();
        }
    }
}
