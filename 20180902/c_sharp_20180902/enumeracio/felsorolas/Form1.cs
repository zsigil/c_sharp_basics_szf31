using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace felsorolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //nem kell idézőjel a napok köré
        //ha a hétfőt beállítom 5-re, onnan indul a számozás
        enum Napok { hétfő=5, kedd, szerda, csütörtök, péntek, szombat, vasárnap};

        private void Form1_Load(object sender, EventArgs e)
        {
            //felsorolt típus: elemek névvel ellátott halmaza
            //nullával kezdődik a sorszámozás, ez megváltoztatható

            Napok nap = Napok.hétfő; //létre tudunk hozni ilyen típusú változót
            label1.Text = nap.ToString();

            int nap_sorszam = (int)Napok.hétfő;

            label2.Text = nap_sorszam.ToString();




        }
    }
}
