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
    public partial class GirisForm : Form
    {
        private AnaForm anaform;
        private KullaniciGirisFormu kullanici_giris_formu;
        private KullaniciRandevuFormu kullanici_randevu_formu;
        public GirisForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            
        }
        public GirisForm(AnaForm form)
        {
            InitializeComponent();
            this.anaform = form;
        }
        public GirisForm(KullaniciGirisFormu kullanici_form)
        {
            InitializeComponent();
            this.kullanici_giris_formu = kullanici_form;
        }
        public GirisForm(KullaniciRandevuFormu kullanici_randevu_form)
        {
            InitializeComponent();
            this.kullanici_randevu_formu = kullanici_randevu_form;
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            KullaniciRandevuFormu kullanici_randevu_form = new KullaniciRandevuFormu(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İster misiniz?","Çıkış",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiGirisi git = new YoneticiGirisi(this);
            git.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Text == "Success")
            {
                this.Hide();
            }
            else if (label2.Text == "Show")
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciRandevuFormu git = new KullaniciRandevuFormu(this);
            git.ShowDialog();

        }

    }
}
