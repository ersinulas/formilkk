using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formilkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OnMuhasebeEntities _db = new OnMuhasebeEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtkullanici.Text;
            string sifre = txtsifre.Text;
            var bilgi = _db.Kullanicilar.FirstOrDefault(g => g.kullanici == kullanici && g.sifre == sifre);
            if (bilgi != null)
            {
                AnaEkran nn = new AnaEkran();
                nn.Show();
                this.Hide();
            }

            lblhata.Text = "Kullanıcı Adınız yada Sifreniz hatalıdır Lütfen Tekrar Deneyiniz";
            lblhata.BackColor = Color.Red;
            txtkullanici.Text = "";
            txtsifre.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}