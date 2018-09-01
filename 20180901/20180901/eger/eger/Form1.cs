using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(x_input.Text);
            int y = int.Parse(y_input.Text); ;


            //példányosítani kell, úgy lehet neki koordinátát megadni
            button1.Location = new Point(x, y);
        }
    }
}
