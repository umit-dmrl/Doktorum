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
using System.Drawing.Imaging;

namespace Doktorum
{
    public partial class HekimEkleme : Form
    {
        public HekimEkleme()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void HekimEkleme_Load(object sender, EventArgs e)
        {
            string gelenVeri = vt.ComboBoxVeriCek("Hastaneler", "hastaneAdi");
            string[] degerler = gelenVeri.Split('-');
            for (int i = 0; i < degerler.Length - 1; i++)
            {
                comboBox1.Items.Add(degerler[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hastane Seçiniz")
            {
                MessageBox.Show("Hastane Seçimi Yapmadınız !","Uyarı");
            }
            else
            {
                Random rnd = new Random();
                string resim = "";
                if (pictureBox1.Image == null)
                {
                    resim = "yok";
                }
                else
                {
                    resim = DateTime.Now.Second.ToString()+rnd.Next(100,9999).ToString()+".jpg";
                    pictureBox1.Image.Save("resimler/"+resim, ImageFormat.Jpeg);
                }
                string[] sutunlar = { "adsoyad", "tel", "eposta", "web", "dtarih", "egitim", "hastane","uzmanlik","resim", "aciklama" };
                string[] degerler = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text, textBox5.Text, comboBox1.Text,comboBox2.Text,resim, richTextBox1.Text };
                bool durum = vt.ekle("Hekimler", sutunlar, degerler);
                if (durum == true)
                {
                    MessageBox.Show("Bilgiler Kaydedildi");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    comboBox1.Text = "Hastane Seçiniz";
                    richTextBox1.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Bilgiler Kaydedilirken Hata Oluştu !","Hata");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName.ToString();
            }
        }

    }
}
