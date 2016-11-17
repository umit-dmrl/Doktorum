using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

/*
Proje Adı : Doktorum
Proje Geliştiricisi : Ümit DEMİREL
Proje Amaç / Kapsamı : Hastanelerin Ve Hastanelere Bağlı Doktorların Yönetimini Sağlamak Ve Hastaların Randevu Almalarını Sağlamak
Sürüm : V1
*/

namespace Doktorum
{
    public partial class AnaForm : Form
    {
        private YoneticiGirisi form_yonetici_giris;
        public AnaForm()
        {
            InitializeComponent();
        }
        public AnaForm(YoneticiGirisi form)
        {
            InitializeComponent();
            this.form_yonetici_giris = form;
        }
        void YavruForm(Form form_adi)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == form_adi.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
            }
            if (durum == false)
            {
                form_adi.MdiParent = this;
                form_adi.Show();
            }
        }
        private void hastaneKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaneKayit git = new HastaneKayit();
            YavruForm(git);
        }

        private void hastaneListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaneListesi git = new HastaneListesi();
            YavruForm(git);
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void poliklinikAtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliklinikAtama git = new PoliklinikAtama();
            YavruForm(git);
        }

        private void hekimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HekimEkleme git = new HekimEkleme();
            YavruForm(git);
        }

        private void hekimListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HekimBilgileriniGuncelle git = new HekimBilgileriniGuncelle();
            YavruForm(git);
        }

        private void çalışmaSaatleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalismaGunleri git = new CalismaGunleri();
            YavruForm(git);
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuAl git = new RandevuAl();
            YavruForm(git);
        }
        //Mause sağ tık eventi açılır menü kodları
        //Programı kapat
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","Bilgi",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
        //Gelişrici mesajı
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ümit Demirel","Otomasyon Geliştirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void OtomasyonHakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "Otomasyonun temel amacı standart randevu sistemlerinden farklı bir otomasyon sistemi sunmaktır.\n";
            str += "Hekim yönetim sistemi ile hekim kontrolü daha sağlıklı yapılabilmektedir.";
            MessageBox.Show(str, "Hekim Ve Randevu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                GirisForm giris_form = new GirisForm(this);
                giris_form.Close();
                this.Close();
            }
        }

        private void randevuSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAdSoyad git = new lblAdSoyad();
            YavruForm(git);
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_yonetici_giris.Show();
        }
    }
}
