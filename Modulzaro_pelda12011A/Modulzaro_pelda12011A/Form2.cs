using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CSV_iras;

namespace Modulzaro_pelda12011A
{
    public partial class Form2 : Form
    {
        List<Rendeles> rendelesek; //Lista amiben a rekordokat tároljuk
        List<Rendeles> keresett_rendeles;
        List<VevokPizza> vevok_pizzak;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rendelesek = Adatb_kezelo.Beolvas_rendeles();
        }

        //új rendelés rögzítése
        Rendeles rendeles;
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            //példányosítjuk az új vevőt
            try
            {
                rendeles = new Rendeles(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), dateTimePicker1.Value, Convert.ToInt32(textBox6.Text));
            }

            catch (FormatException kiv)
            {
                MessageBox.Show(kiv.Message, "Hibás adatbevitel!");
            }
            //ezzel a példánnyal hívjuk meg az Uj_rendelesBevitel metódust
            Adatb_kezelo.Uj_rendelesBevitel(rendeles);

            //Frissítjük a megjelenítést            
            rendelesek = Adatb_kezelo.Beolvas_rendeles();
            
        }

        //rendelés módosítása
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //példányosítunk egy objektumot a textboxokból
                rendeles = new Rendeles(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), dateTimePicker1.Value, Convert.ToInt32(textBox6.Text));
                Adatb_kezelo.RendelesModositas(rendeles);

                //Frissítjük a megjelenítést                    
                rendelesek = Adatb_kezelo.Beolvas_rendeles();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Megjelenítés listView -ban
        void listview_megjelenit()
        {
            listView1.View = View.Details; //View tulajdonság Detailsre állítása
            listView1.Items.Clear(); //Kiürítjük a listát
            if (listView1.Columns.Count == 0)
            {
                //Felderítjük, hogy milyen  property -i (oszlopai) vannak a táblának és ezeket hozzáadjuk a ListView -hoz
                foreach (PropertyInfo elem in typeof(Rendeles).GetProperties())
                {
                    listView1.Columns.Add(elem.Name);
                }
            }
            foreach (Rendeles elem in keresett_rendeles)
            {
                //string vektor a mezők értékeinek tárolásához
                string[] adatok = new string[typeof(Rendeles).GetProperties().Length];

                for (int i = 0; i < adatok.Length; i++)
                {
                    //feltöltjük a vektort a mezők értékeivel
                    adatok[i] = typeof(Rendeles).GetProperties()[i].GetValue(elem).ToString();
                }
                listView1.Items.Add(new ListViewItem(adatok));//hozzáadjuk a listView -hoz a rekordot tartalmazó stringet
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //megkeressük a rendelések listából azt az elemet aminek az azonosítója megegyezik a textbox1-ben találhatóval
            Rendeles keresett = null;
            foreach (Rendeles elem in rendelesek)
            {
                if (elem.Rendeles_ID == Convert.ToInt32(textBox1.Text))
                {
                    keresett = elem;
                }
            }

            keresett_rendeles = Adatb_kezelo.RendelesKeres(keresett);
            listview_megjelenit();
        }

        //Megjelenítés listBoxban
        void listbox_megjelenit()
        {
            listBox1.Items.Clear();
            foreach (var elem in vevok_pizzak)
            {
                listBox1.Items.Add(elem.V_nev+"; "+elem.P_nev);
            }
        }

        //Vevők és pizzák
        private void button4_Click(object sender, EventArgs e)
        {
            vevok_pizzak = Adatb_kezelo.Vevo_Pizza();
            listbox_megjelenit();
        }

        //A pizzák száma
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Adatb_kezelo.Pizzakszama().ToString(), "A pizzák száma:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sor;
            foreach (var elem in rendelesek)
            {
                sor = elem.Rendeles_ID.ToString() + ";" + elem.V_id.ToString() + ";" + elem.P_id.ToString() + ";" + elem.Mennyiseg.ToString() + ";" + elem.Datum.ToString() + ";" + elem.Ido.ToString();
                Class1.csv(sor);
            }
        }
    }
}
