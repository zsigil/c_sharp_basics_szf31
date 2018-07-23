using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_legordulo_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("január");
            comboBox1.Items.Add("február");

            for (int i = 1900; i < 2019; i+=2)
            {
                comboBox1.Items.Add(i);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }
    }
}
