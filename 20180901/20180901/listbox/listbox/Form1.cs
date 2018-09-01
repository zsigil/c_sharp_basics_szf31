using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //a sorszám mindig a listbox1 elemszámig megy
            numericUpDown1.Maximum = listBox1.Items.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            numericUpDown1.Maximum = listBox1.Items.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text != "")
            {
                listBox1.Items.Insert((int)numericUpDown1.Value-1, textBox1.Text);
                numericUpDown1.Maximum = listBox1.Items.Count;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ha sorszám alapján akarom eldönteni,mit töröljünk
            //listBox1.Items.RemoveAt((int)numericUpDown1.Value - 1);

            //ha a listboxban akarom kijelölni, mit töröljek
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            numericUpDown1.Maximum = listBox1.Items.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("bizti?", "Törlés figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (valasz == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                numericUpDown1.Maximum = listBox1.Items.Count;
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            numericUpDown1.Maximum = listBox1.Items.Count;
        }
    }
}
