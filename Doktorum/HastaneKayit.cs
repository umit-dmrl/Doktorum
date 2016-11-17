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
using System.IO;

namespace Doktorum
{
    public partial class HastaneKayit : Form
    {
        public HastaneKayit()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string fileName=rnd.Next(999,99999999).ToString();
            StreamWriter yaz = new StreamWriter(Application.StartupPath+"\\maps\\"+fileName+".html");
            string yazilanlar = richTextBox2.Text;
            yaz.Write(yazilanlar);
            yaz.Close();

            string[] sutunlar = { "hastaneAdi","hastaneTuru", "hastaneTel", "hastaneFax", "hastane_il", "hastaneAdres", "hastaneEmail", "hastaneWeb", "hastaneGoogleMaps" };
            string[] degerler = { textBox1.Text,comboBox2.Text, textBox2.Text, textBox3.Text, comboBox1.Text, richTextBox1.Text, textBox4.Text, textBox5.Text, fileName };
            bool durum = vt.ekle("Hastaneler", sutunlar, degerler);
            if (durum == true)
            {
                MessageBox.Show("Hastane Kaydı Yapıldı", "Bilgi");
                
            }
            else
            {
                MessageBox.Show("Kayıt Yapılırken Bir Hata Oluştu !","Sistem Hatası");
            }
        }
    }
}
