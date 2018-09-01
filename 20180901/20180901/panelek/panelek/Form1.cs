using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panelek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label1.Text = "Nő";
            }

            if (radioButton2.Checked == true)
            {
                label1.Text = "Férfi";
            }

            if (radioButton3.Checked == true)
            {
                label1.Text = "hmmmm";
            }

            if (radioButton4.Checked == true)
            {
                label2.Text = "18 alatt";
            }

            if (radioButton5.Checked == true)
            {
                label2.Text = "18-30";
            }
            if (radioButton6.Checked == true)
            {
                label2.Text = "31-40";
            }
            if (radioButton7.Checked == true)
            {
                label2.Text = "41-60";
            }
            if (radioButton8.Checked == true)
            {
                label2.Text = "61+";
            }
        }
    }
}
