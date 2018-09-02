using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ablak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ablakok száma
        int ablak_azon = 0;

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //új ablakot kell csinálni
            Form2 uj_ablak = new Form2();
            ablak_azon++;
            //kijelöljük, h ki a szülője
            uj_ablak.Show();
            uj_ablak.MdiParent = this;
            uj_ablak.Text = "Ablak" + ablak_azon.ToString();   
        }

        private void lépcsőzetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void mozaikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void megnyitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ha nincs activechild
            if (this.ActiveMdiChild == null)
            {
                Form2 uj_ablak = new Form2();
                uj_ablak.Show();
                uj_ablak.MdiParent = this;

                //megnyitjuk az ablakot a fájlmegnyitáshoz
                //ha ok-t nyomtunk rajta, akkor történjenek az alábbiak

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //a form2 designerben publicra javítani a richtextbox1 példányát
                    //richtextbox1-be betöltjük a kiválasztott rtf-et
                    uj_ablak.richTextBox1.LoadFile(openFileDialog1.FileName);
                    uj_ablak.Text = openFileDialog1.FileName;
                }
            }

            //ha van már activechild
            else
            {
                DialogResult valasz = MessageBox.Show("A fájlt új ablakban nyissuk meg?", "Megnyitás", MessageBoxButtons.YesNoCancel);
                //van már, de mégis új ablakot akarok
                if (valasz == DialogResult.Yes)
                {
                    Form2 uj_ablak = new Form2();
                    uj_ablak.Show();
                    uj_ablak.MdiParent = this;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //a form2 designerben publicra javítani a richtextbox1 példányát
                        uj_ablak.richTextBox1.LoadFile(openFileDialog1.FileName);
                        uj_ablak.Text = openFileDialog1.FileName;
                    }
                }
                //a már nyitott aktív ablakban akarom - "nem"
                if (valasz == DialogResult.No)
                {
                    //HW
                    //utolsó aktív ablakban legyen a megnyitott fájl tartalma
                    
                    Form2 nyitott_ablak = (Form2)ActiveMdiChild;
                    nyitott_ablak.Show();
                    nyitott_ablak.MdiParent = this;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //a form2 designerben publicra javítani a richtextbox1 példányát
                        nyitott_ablak.richTextBox1.LoadFile(openFileDialog1.FileName);
                        nyitott_ablak.Text = openFileDialog1.FileName;
                    }


                }
                //dialogbox "cancel"
                else  
                {
                    this.openFileDialog1.Dispose();
                }
            }

        }
    }
}
