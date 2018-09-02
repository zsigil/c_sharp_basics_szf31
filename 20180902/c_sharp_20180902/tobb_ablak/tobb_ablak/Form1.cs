using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tobb_ablak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // példányosítunk egy új, Form2 típusú ablakot
            Form2 uj_ablak = new Form2();

            //ugyanazon a szálon fut az új ablak, mint  a szülő,
            //csak az egyik lehet aktív:
            //uj_ablak.ShowDialog(); 

            //külön szálon:
            uj_ablak.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
