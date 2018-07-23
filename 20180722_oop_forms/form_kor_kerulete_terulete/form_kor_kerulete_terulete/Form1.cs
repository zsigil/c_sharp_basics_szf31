using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_kor_kerulete_terulete //programunk névtere
{
    //parciális osztály, Form1 Form-ból örököl, de minden részét veszi át

    public partial class Form1 : Form
    {
        //Form1 inicializálását és megjelenítését
        public Form1()
        {
            InitializeComponent();
        }

        double r;//sugár
        //a button1 eseménykezelő metódusa
        //default: Click
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //a textbox text tulajdonsága hordozza a beírt értéket
            r = Convert.ToDouble(textBox4.Text);
            double k = 2 * r * Math.PI;
            double t = Math.Pow(r, 2) * Math.PI;
            //textBox5.Text = Convert.ToString(k);
            //textBox6.Text = Convert.ToString(t);
            textBox5.Text = k.ToString("N2");  //2 tizedesig, numerikus(hosszú szám szépen formázva)
            //textBox6.Text = t.ToString("C3");  // Ft -ot rak hozzá(pénznem 3 tizedesig)
            textBox6.Text = String.Format("{0:F3}", t); //3 tizedesig, nincs formázva
            */
            Szamol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void Szamol()
        {
            r = Convert.ToDouble(textBox4.Text);
            double k = 2 * r * Math.PI;
            double t = Math.Pow(r, 2) * Math.PI;
            textBox5.Text = k.ToString("N2");
            textBox6.Text = String.Format("{0:F3}", t);
        }

        
        private void button2_MouseHover(object sender, EventArgs e)
        {
            //button2.Font.Bold.Equals(true);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Szamol();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            Szamol();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)  //enter
            {
                Szamol();
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            int karakter = e.KeyValue;

            if (karakter >= 48 && karakter <= 57 || karakter==13 || karakter==8) //tehát szám, vagy enter vagy backspace
                { }

            else
            {
                textBox4.Clear();
                MessageBox.Show("számot!");
            }
        }
    }
}
