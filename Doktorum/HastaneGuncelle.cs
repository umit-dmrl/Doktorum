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

namespace Doktorum
{
    public partial class HastaneGuncelle : Form
    {
        public HastaneGuncelle()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string[] sutunlar = { "hastaneAdi", "hastaneTuru", "hastaneTel", "hastaneFax", "hastane_il", "hastaneAdres", "hastaneEmail", "hastaneWeb", "hastaneGoogleMaps" };
            string[] degerler = { textBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, comboBox1.Text, richTextBox1.Text, textBox4.Text, textBox5.Text, lblFileName.Text };
            bool durum = vt.guncelle("Hastaneler", sutunlar, degerler,"id="+label1.Text);
            if (durum == true)
            {
                StreamWriter yaz=null;
                try
                {
                    string maps_html = lblFileName.Text;
                    yaz = new StreamWriter(Application.StartupPath+"\\maps\\" + maps_html + ".html");
                    string getMaps = richTextBox2.Text;
                    yaz.Write(getMaps);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Google Maps Verileri Dosyaya Yazılırken Hata Oluştu !\nHata : "+ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    yaz.Close();
                }
                MessageBox.Show("Hastane Bilgileri Güncellendi", "Bilgi");
            }
            else
            {
                MessageBox.Show("Güncelleme Yapılırken Bir Hata Oluştu !", "Sistem Hatası");
            }
        }

        private void HastaneGuncelle_Load(object sender, EventArgs e)
        {
            string maps_html = lblFileName.Text;
            FileInfo dosya = new FileInfo(@"maps\" +maps_html+".html");
            StreamReader oku = dosya.OpenText();
            richTextBox2.Text = oku.ReadToEnd();
        }
    }
}
