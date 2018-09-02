using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struktura_adatszerkezet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //struktúra(rekord)létrehozása
        struct Autok
        {
            //a struktúra adatmezői
            public string rszam, marka, tipus, uzanyag;
            public int hurtart, evjarat;

        }
        //max 100 autó adatait tároljuk
        const int max_elem = 3;

        Autok[] tautok = new Autok[max_elem];  //autók tárolásához szükséges vektor
        int n = 0;  //ebben tároljuk, h hogy hány autót tároltunk összesen

        private void button1_Click(object sender, EventArgs e)
        {
            if (n<max_elem)
            {
                tautok[n].rszam = textBox1.Text;
                tautok[n].marka = textBox2.Text;
                tautok[n].tipus = textBox3.Text;
                try
                {
                    tautok[n].hurtart = int.Parse(textBox4.Text);
                    tautok[n].evjarat = int.Parse(textBox5.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("csak számot!");
                }
                
                tautok[n].uzanyag = textBox6.Text;
                n++;
            }

            else
            {
                MessageBox.Show("megtelt a lista(vektor)");
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                string my_string = string.Format("{0}, {1}, {2}, {3}, {4}, {5}", 
                    tautok[i].rszam, tautok[i].marka, tautok[i].tipus, 
                    tautok[i].hurtart, tautok[i].evjarat, tautok[i].uzanyag);

                listBox1.Items.Add(my_string);
            }
        }
    }
}
