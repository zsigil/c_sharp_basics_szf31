using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_szamitasok; // ez nem szükséges

namespace kulon_fajl_osztaly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            Szamitas.sugar = double.Parse(textBox1.Text);
            textBox2.Text = Szamitas.Terulet().ToString();
            textBox3.Text = Szamitas.Kerulet().ToString();
        }
    }
}
