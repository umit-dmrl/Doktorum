using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Doktorum
{
    public partial class HekimUpdateProcess : Form
    {
        public HekimUpdateProcess()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        string resimYolu;
        private void HekimUpdateProcess_Load(object sender, EventArgs e)
        {
            string[] sutunlar = { "adsoyad", "tel", "eposta", "web", "dtarih", "egitim", "hastane", "uzmanlik", "resim", "aciklama" };
            string bilgiler = vt.veri_cek("Hekimler", sutunlar, "id=" + label12.Text);
            string[] degerler = bilgiler.Split('$');
            string adsoyad="",tel="",eposta="",web="",dtarih="",egitim="",hastane="",uzmanlik="",resim="",aciklama="";
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
            txtAdSoyad.Text = adsoyad;
            txtEgitim.Text = egitim;
            txtEposta.Text = eposta;
            txtTel.Text = tel;
            txtWeb.Text = web;
            comboBox1.Text = hastane;
            comboBox2.Text = uzmanlik;
            richTextBox1.Text = aciklama;
            pictureBox1.ImageLocation = "resimler/"+resim;
            dateTimePicker1.Text = dtarih;
            //
            resimYolu = resim;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("Hastane Veya Uzmanlık Kısımlarını Boş Bırakmış Olmalısınız ! Lütfen Doldurun.","Uyarı");
            }
            else
            {
                string resimAdi = "";
                Random rnd = new Random();
                if (pictureBox1.Image == null)
                {
                    resimAdi = "yok";
                }
                else
                {
                    if ("resimler/" + resimYolu == pictureBox1.ImageLocation)
                    {
                        resimAdi = resimYolu;
                    }
                    else
                    {
                        resimAdi = DateTime.Now.Second.ToString() + rnd.Next(100, 99999) + ".jpg";
                    }
                    if (resimYolu != "yok")
                    {
                        File.Delete("resimler/" + resimYolu);
                    }
                    pictureBox1.Image.Save("resimler/" + resimAdi, ImageFormat.Jpeg);
                    string[] sutunlar = { "adsoyad", "tel", "eposta", "web", "dtarih", "egitim", "hastane", "uzmanlik", "resim", "aciklama" };
                    string[] degerler = { txtAdSoyad.Text, txtTel.Text, txtEposta.Text, txtWeb.Text, dateTimePicker1.Text, txtEgitim.Text, comboBox1.Text, comboBox2.Text, resimAdi, richTextBox1.Text };
                    bool durum = vt.guncelle("Hekimler", sutunlar, degerler, "id=" + label12.Text);
                    if (durum == true)
                    {
                        MessageBox.Show("Hekim Bilgileri Güncellendi", "Bilgi");
                    }
                    else
                    {
                        MessageBox.Show("Hekim Bilgileri Güncellenirken Bir Hata Oluştu", "Hata");
                    }
                }
            }
        }
    }
}
