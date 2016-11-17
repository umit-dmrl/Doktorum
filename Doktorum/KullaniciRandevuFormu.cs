using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doktorum
{
    public partial class KullaniciRandevuFormu : Form
    {
        private KullaniciGirisFormu form_giris;
        private GirisForm ana_giris_formu;
        public KullaniciRandevuFormu()
        {
            InitializeComponent();
        }
        public KullaniciRandevuFormu(KullaniciGirisFormu form)
        {
            InitializeComponent();
            this.form_giris = form;
        }
        public KullaniciRandevuFormu(GirisForm form2)
        {
            InitializeComponent();
            this.ana_giris_formu = form2;
        }
        Veritabani vt = new Veritabani();
        private void KullaniciRandevuFormu_Load(object sender, EventArgs e)
        {
            ana_giris_formu.label2.Text = "Success";
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ana_giris_formu.label2.Text = "Show";
            this.Close();
        }

        private void KullaniciRandevuFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ana_giris_formu.label2.Text = "Show";
        }


        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAl randevu = new RandevuAl();
            randevu.ShowDialog();
        }

        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            lblAdSoyad git = new lblAdSoyad();
            git.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            ana_giris_formu.label2.Text = "Show";
            this.Close();
        }

    }
}
