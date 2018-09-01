using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eger2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // az e paraméter hordozza az egér aktuális koordinátáit
            //írjuk ki, épp hol van az egér
            int eger_x = e.X;
            int eger_y = e.Y;

            // form max méretét beállítani 850x500-ra,hogy ne írjon ki hülyeségeket
            //folyamatosan kiírja, ahogy mozog
          
            if (eger_x>0 && eger_x<850)
            {
                x_input.Text = eger_x.ToString();
            }

            if (eger_y > 0 && eger_y < 500)
            {
                y_input.Text = eger_y.ToString();
            }


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //írjuk ki a koordinátákat, hogy hova kattintottunk
            int eger_x = e.X;
            int eger_y = e.Y;

            x2_input.Text = eger_x.ToString();
            y2_input.Text = eger_y.ToString();

        }
    }
}
