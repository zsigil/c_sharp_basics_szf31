using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; //Ez kell a property -hez!!!

namespace Modulzaro_pelda12011A
{
    public partial class Form1 : Form
    {
        List<Vevo> vevok; //Lista amiben a rekordokat tároljuk
        List<Vevo> keresett_vevo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //A listát feltöltjük a tábla soraival
                vevok = Adatb_kezelo.Beolvas();                

                //Meghívjuk a metódusokat                
                datagridview_megjelenit();
                

            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Megjelenítés dataGridView -ban
        void datagridview_megjelenit()
        {
            //Inicializálás
            dataGridView1.DataSource = null;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                foreach (PropertyInfo elem in typeof(Vevo).GetProperties())
                {
                    dataGridView1.Columns.Add(elem.Name, elem.Name);
                }
            }
            foreach (Vevo elem in vevok) //sorok
            {
                dataGridView1.Rows.Add(); //sorokon belül az oszlopok (mezők) hozzáadása
                for (int i = 0; i < typeof(Vevo).GetProperties().Length; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = typeof(Vevo).GetProperties()[i].GetValue(elem);
                }
            }
        }

        //új vevő rögzítése
        Vevo vevo;
        private void button1_Click(object sender, EventArgs e)
        {
            //példányosítjuk az új vevőt
            try
            {
                vevo = new Vevo(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text), textBox7.Text);
            }

            catch (FormatException kiv)
            {
                MessageBox.Show(kiv.Message, "Hibás adatbevitel!");
            }
            //ezzel a példánnyal hívjuk meg az Uj_Bevitel metódust
            Adatb_kezelo.Uj_Bevitel(vevo);                                  

            //Frissítjük a megjelenítést            
            vevok = Adatb_kezelo.Beolvas();
            datagridview_megjelenit();
        }

        //vevő törlés
        private void button2_Click(object sender, EventArgs e)
        {
            //megkeressük a vevők listából azt az elemet aminek az ID-je megegyezik a textbox1-ben találhatóval
            Vevo torlendo=null;
            foreach (Vevo elem in vevok)
            {
                if (elem.Vevo_ID == Convert.ToInt32(textBox1.Text))
                {
                    torlendo = elem;
                }
            }
            if (MessageBox.Show("Biztosan törlöd ezt a vevőt?", "Figyelmeztetés!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Meghívjuk a Torles metódust azzal az objektummal aminek az ID -je a textbox1 -ben van
                    Adatb_kezelo.Torles(torlendo);                    

                    //Frissítjük a megjelenítést                    
                    vevok = Adatb_kezelo.Beolvas();
                    datagridview_megjelenit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //vevő módosítás
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //példányosítunk egy objektumot a textboxokból
                vevo = new Vevo(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text), textBox7.Text);
                Adatb_kezelo.Modositas(vevo);

                //Frissítjük a megjelenítést                    
                vevok = Adatb_kezelo.Beolvas();
                datagridview_megjelenit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //vevő keresése
        private void button4_Click(object sender, EventArgs e)
        {

            //megkeressük a vevők listából azt az elemet aminek a neve megegyezik a textbox2-ben találhatóval
            Vevo keresett = null;
            foreach (Vevo elem in vevok)
            {
                if (elem.Vevo_Nev == textBox2.Text)
                {
                    keresett = elem;
                }
            }

            keresett_vevo=Adatb_kezelo.Keres(keresett);
            datagridview_kereses_megjelenit();
        }

        //Keresés eredményének megjelenítése dataGridView -ban
        void datagridview_kereses_megjelenit()
        {
            //Inicializálás
            dataGridView2.DataSource = null;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Rows.Clear();

            if (dataGridView2.Columns.Count == 0)
            {
                foreach (PropertyInfo elem in typeof(Vevo).GetProperties())
                {
                    dataGridView2.Columns.Add(elem.Name, elem.Name);
                }
            }
            foreach (Vevo elem in keresett_vevo) //sorok
            {
                dataGridView2.Rows.Add(); //sorokon belül az oszlopok (mezők) hozzáadása
                for (int i = 0; i < typeof(Vevo).GetProperties().Length; i++)
                {
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[i].Value = typeof(Vevo).GetProperties()[i].GetValue(elem);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 uj_ablak = new Form2();
            uj_ablak.Show();
        }
    }
}
