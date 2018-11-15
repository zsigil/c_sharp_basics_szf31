using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iras_txtbe;
using iskolak_csvbe; //tanulók lesznek, nem iskolák

namespace modulzaro_gyakorlas_iskola
{
    public partial class Form1 : Form
    {
        // létrehozzuk őket, hogy tudjuk használni később
        List<Iskola> iskolak;
        List<Tanulo> tanulok;
        Iskola iskola;
        Tanulo tanulo;

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

        void listview_megjelenit_tanulo()
        {
            listView2.View = View.Details;
            listView2.Items.Clear();
            var properties = typeof(Tanulo).GetProperties();

            //oszlopok létrehozása(ha nincsenek)
            if (listView2.Columns.Count == 0)
            {
                foreach (var item in properties)
                {
                    listView2.Columns.Add(item.Name); //oszlopnév a property neve lesz
                }

            }

            //töltsük fel sorokkal



            foreach (var item in tanulok) //egy elem egy sor
            {
                //string vektor a mezők értékeinek tárolásához
                //annyi eleme lesz a stringnek, ahány property van a könyv osztályban
                string[] adatok = new string[properties.Length];
                for (int i = 0; i < adatok.Length; i++)
                {
                    //feltöltjük a mezők értékeivel a vektort
                    adatok[i] = properties[i].GetValue(item).ToString();
                }

                listView2.Items.Add(new ListViewItem(adatok));
            }

        }

        void datagridview_megjelenit_tanulo()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            var properties = typeof(Tanulo).GetProperties();

            if (dataGridView1.Columns.Count == 0)
            {
                foreach (var item in properties)
                {
                    dataGridView1.Columns.Add(item.Name, item.Name); //oszlopnév a property neve lesz
                }
            }

            //sorok hozzáadása
            foreach (var item in tanulok)
            {
                dataGridView1.Rows.Add();//üres sor hozzáadása először

                //egy soron belül az oszlopok(mezők) hozzáadása
                for (int i = 0; i < properties.Length; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = properties[i].GetValue(item);
                }
            }
        }

        float osztondij_szamolasa(Tanulo tanulo)
        {
            return tanulo.Atlag * 1000;
        }

        int eletkor_szamitasa(Tanulo tanulo)
        {
            string eletkorstring = tanulo.Szul;
            string[] eletkorarr = eletkorstring.Split('-');
            int eletkor = 2018 - int.Parse(eletkorarr[0]);
            return eletkor;
        }

        string iskolak_abcben()
        {
            List<Iskola> iskolak2 = Adatbaziskezelo.Isk_beolvas_abcben();
            string mystring = "";
            foreach (var item in iskolak2)
            {
                
                mystring += item.Nev.ToString();
                mystring += ';';
                mystring += item.Azon.ToString();
                mystring += ';';
                mystring += item.Varos.ToString();
                mystring += item.Irszam.ToString();
                mystring += item.Utca.ToString();
                mystring += ';';
                mystring += item.Telszam.ToString();
                mystring += "\n";

            }
            return mystring;
        }

        string tanulok_abcben()
        {
            List<Tanulo> tanulok3 = Adatbaziskezelo.Tan_beolvas_abcben();
            string mystring = "";
            foreach (var item in tanulok3)
            {

                mystring += item.Nev.ToString();
                mystring += ';';
                mystring += item.Azon.ToString();
                mystring += ';';
                mystring += item.Szul.ToString();
                mystring += ';';
                mystring += item.Varos.ToString();
                mystring += ';';
                mystring += item.Irszam.ToString();
                mystring += ';';
                mystring += item.Utca.ToString();
                mystring += ';';
                mystring += item.Anyjaneve.ToString();
                mystring += ';';
                mystring += item.Osztaly.ToString();
                mystring += ';';
                mystring += (item.Atlag.ToString() + '\n');

            }

            return mystring;
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

            tanulok = Adatbaziskezelo.Tan_beolvas();
            datagridview_megjelenit_tanulo();
            //listview_megjelenit_tanulo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //iskola módosítása 
            var melyikindex = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            var melyikazon = iskolak[melyikindex].Azon;
            iskola = new Iskola(melyikazon, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            Adatbaziskezelo.Modosit_iskola(iskola);

            iskolak.RemoveAt(melyikindex);
            iskolak.Add(iskola);
            listview_megjelenit_iskola();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //uj tanulo letrehozasa
        private void button3_Click(object sender, EventArgs e)
        {
            
            tanulo = new Tanulo(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, float.Parse(textBox15.Text));
            Adatbaziskezelo.Uj_tanulo(tanulo); //csak adatbázisba viszi be

            tanulok.Add(tanulo); //a listánkba is berakja
            datagridview_megjelenit_tanulo();
        }

        //tanulo módosítása
        private void button4_Click(object sender, EventArgs e)
        {
            var melyikindex = dataGridView1.CurrentCell.RowIndex;
            var melyikazon = tanulok[melyikindex].Azon;
            tanulo = new Tanulo(melyikazon, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, float.Parse(textBox15.Text));
            Adatbaziskezelo.Modosit_tanulo(tanulo);

            tanulok.RemoveAt(melyikindex);
            tanulok.Add(tanulo);
            datagridview_megjelenit_tanulo();

        }

        //tanulo törlése
        private void button5_Click(object sender, EventArgs e)
        {
            var melyikindex = dataGridView1.CurrentCell.RowIndex;
            tanulo = tanulok[melyikindex];
            Adatbaziskezelo.Torol_tanulo(tanulo);
            tanulok.RemoveAt(melyikindex);
            datagridview_megjelenit_tanulo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var melyikindex = dataGridView1.CurrentCell.RowIndex;
            tanulo = tanulok[melyikindex];

            float osztondij = osztondij_szamolasa(tanulo);
            textBox16.Text = osztondij.ToString();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            //tanulo életkora
            var melyikindex = dataGridView1.CurrentCell.RowIndex;
            tanulo = tanulok[melyikindex];

            textBox17.Text = eletkor_szamitasa(tanulo).ToString();

        }
        //iskola txtbe
        private void button8_Click(object sender, EventArgs e)
        {
            string mypath = @"F:\szf31\csharp\csharp_programjaim\modulzaro_gyakorlas\iskolak.txt";
            string iskolak_abc = iskolak_abcben();
            iras_txtbe.Class1.txtbe_irom(mypath, iskolak_abc);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string mypath = @"F:\szf31\csharp\csharp_programjaim\modulzaro_gyakorlas\tanulok.csv";
            string tanulok_abc = tanulok_abcben();
            iskolak_csvbe.Class1.csvbe_irom(mypath, tanulok_abc);
        }
    }
}
