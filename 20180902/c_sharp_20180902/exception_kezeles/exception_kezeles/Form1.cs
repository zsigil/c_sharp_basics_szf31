using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_kezeles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kivételkezelés(exception handling)
            //exception  - a progi futását megakadályozza
            //1. a keretrendszer generálja ((előre definiált)
            //2. mi magunk szándékosan váltjuk ki
            bool problem = false;

            
            try
            {
                int a = int.Parse(textBox1.Text);                

                //saját kivétel létrehozása(nem előre definiált)
                if (a>100)
                {
                    throw new Exception("csak 100 alatt");
                }

                // ez itt egy bug
                float b = (float)5 / a;  //ha a nulla,simán hagyja, és végtelent ad
                //int b = 5 / a;
                label1.Text = b.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("nullával nem osztunk");
                problem = true;
            }
            catch(FormatException formatum_hiba)
            {
                //exceptionhöz tartozó szöveget is kiírja
                MessageBox.Show(formatum_hiba.Message);
                problem = true;
            }

            // általános hiba, he előre nem tudtunk felkészülni - a lista legvégére!
            catch (Exception alt_kivetel)
            {
                MessageBox.Show(alt_kivetel.Message);
                label1.Text = "";
                problem = true;
            }

            //minden esetben lefut, akár volt kivétel, akár nem
            finally
            {
                if (problem)
                {
                    label2.Text = "jaj";
                }
                else
                {
                    label2.Text = "hurrá";
                }
               
            }

        }
    }
}
