using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar2.Value, hScrollBar3.Value, hScrollBar1.Value);
            textBox1.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar2.Value, hScrollBar3.Value, hScrollBar1.Value);
            textBox2.Text = hScrollBar3.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar2.Value, hScrollBar3.Value, hScrollBar1.Value);
            textBox3.Text = hScrollBar1.Value.ToString();
        }
    }
}
