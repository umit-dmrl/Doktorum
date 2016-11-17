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
    public partial class HekimDetay : Form
    {
        private lblAdSoyad form_radevuSorgula;
        public HekimDetay()
        {
            InitializeComponent();
        }
        public HekimDetay(lblAdSoyad form)
        {
            InitializeComponent();
            this.form_radevuSorgula = form;
        }
        Veritabani vt = new Veritabani();
        private void HekimDetay_Load(object sender, EventArgs e)
        {
            string[] sutunlar = { "adsoyad", "tel", "eposta", "web", "dtarih", "egitim", "hastane", "uzmanlik", "resim", "aciklama" };
            string bilgiler = vt.veri_cek("Hekimler", sutunlar, "id=" + lblHekimID.Text);
            string[] degerler = bilgiler.Split('$');
            string adsoyad = "", tel = "", eposta = "", web = "", dtarih = "", egitim = "", hastane = "", uzmanlik = "", resim = "", aciklama = "";
            for (int i = 0; i < degerler.Length - 1; i++)
            {
                adsoyad = degerler[0].ToString();
                tel = degerler[1].ToString();
                eposta = degerler[2].ToString();
                web = degerler[3].ToString();
                dtarih = degerler[4].ToString();
                egitim = degerler[5].ToString();
                hastane = degerler[6].ToString();
                uzmanlik = degerler[7].ToString();
                resim = degerler[8].ToString();
                aciklama = degerler[9].ToString();
            }
            lblAdSoyad.Text = adsoyad;
            lblEgitim.Text = egitim;
            lblEposta.Text = eposta;
            lblTel.Text = tel;
            lblWebSitesi.Text = web;
            lblHastaneAdi.Text = hastane;
            lblUzmanlik.Text = uzmanlik;
            richTextBox1.Text = aciklama;
            pictureBox1.ImageLocation = "resimler/" + resim;
            lblDogumTarihi.Text = dtarih;
        }
    }
}
