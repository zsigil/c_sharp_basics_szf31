using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using szamitasok_BL;//Ez hasznos, de nem kötelező!

namespace dll_gyak_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szamitasok_BL.Kor kor_sz = new szamitasok_BL.Kor();
            kor_sz.sugar = double.Parse(textBox1.Text);
            textBox2.Text = kor_sz.Terulet().ToString();
            textBox3.Text = kor_sz.Kerulet().ToString();
        }
    }
}
