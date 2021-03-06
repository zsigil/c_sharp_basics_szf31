﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace modulzaro_gyakorlas_orai
{
    public partial class Form1 : Form
    {

        List<Iskola> iskolak;
        List<Tanulo> tanulok;
        Iskola iskola;
        Tanulo tanulo;

        public Form1()
        {
            InitializeComponent();
        }

        //megjelenítés listviewban
        void listview_megjelenit_iskola()
        {
 
            listView1.View = View.Details;
            listView1.Items.Clear();
            var properties = typeof(Iskola).GetProperties();

            //oszlopok létrehozása(ha nincsenek)
            if (listView1.Columns.Count == 0)
            {
                foreach (var item in properties)
                {
                    listView1.Columns.Add(item.Name); //oszlopnév a property neve lesz
                }

            }


            foreach (var item in iskolak) //egy elem egy sor
            {
                //string vektor a mezők értékeinek tárolásához
                //annyi eleme lesz a stringnek, ahány property van a könyv osztályban
                string[] adatok = new string[properties.Length];
                for (int i = 0; i < adatok.Length; i++)
                {
                    //feltöltjük a mezők értékeivel a vektort
                    adatok[i] = properties[i].GetValue(item).ToString();
                }

                listView1.Items.Add(new ListViewItem(adatok));
            }

        }

        void datagridview_megjelenit_tanulo()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            var properties = typeof(Tanulo).GetProperties();

            if (dataGridView1.Columns.Count == 0)
            {
                foreach (var item in properties)
                {
                    dataGridView1.Columns.Add(item.Name, item.Name); //oszlopnév a property neve lesz
                }
            }

            //sorok hozzáadása
            foreach (var item in tanulok)
            {
                dataGridView1.Rows.Add();//üres sor hozzáadása először

                //egy soron belül az oszlopok(mezők) hozzáadása
                for (int i = 0; i < properties.Length; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = properties[i].GetValue(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iskolak = Adatb_kezelo.Beolvas_iskola();
            tanulok = Adatb_kezelo.Beolvas_tanulo();
            listview_megjelenit_iskola();
            datagridview_megjelenit_tanulo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iskola = new Iskola(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            Adatb_kezelo.Uj_iskola_bevitel(iskola);
            iskolak.Add(iskola);
            listview_megjelenit_iskola();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var melyikindex = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            var melyikazon = iskolak[melyikindex].Iskola_azon;
            iskola = new Iskola(melyikazon, textBox2.Text, textBox3.Text, textBox4.Text);
            Adatb_kezelo.Iskola_modositas(iskola);
            iskolak.RemoveAt(melyikindex);
            iskolak.Add(iskola);
            listview_megjelenit_iskola();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var melyikindex = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            var melyikazon = iskolak[melyikindex].Iskola_azon;
            iskola = new Iskola(melyikazon, textBox2.Text, textBox3.Text, textBox4.Text);
            Adatb_kezelo.Iskola_torles(iskola);
            iskolak.RemoveAt(melyikindex);
            listview_megjelenit_iskola();

        }
    }
}
