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
    public partial class HekimBilgileriniGuncelle : Form
    {
        public HekimBilgileriniGuncelle()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void HekimListesi()
        {           
            vt.baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Hekimler",vt.baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem liste = new ListViewItem(oku["id"].ToString());
                liste.SubItems.Add(oku["adsoyad"].ToString());
                liste.SubItems.Add(oku["hastane"].ToString());
                liste.SubItems.Add(oku["uzmanlik"].ToString());
                listView1.Items.Add(liste);
            }
            oku.Close();
            vt.baglanti.Close();
        }
        void Filtre(string adsoyad,string hastane)
        {
            if (hastane == "Seçiniz" || hastane == "")
            {
                hastane = "test";
            }
            if (adsoyad == "")
            {
                adsoyad = "test";
            }
            listView1.Items.Clear();
            vt.baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Hekimler where adsoyad like '%"+adsoyad+"%' or hastane like '%"+hastane+"%'", vt.baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem liste = new ListViewItem(oku["id"].ToString());
                liste.SubItems.Add(oku["adsoyad"].ToString());
                liste.SubItems.Add(oku["hastane"].ToString());
                liste.SubItems.Add(oku["uzmanlik"].ToString());
                listView1.Items.Add(liste);
            }
            oku.Close();
            vt.baglanti.Close();
        }
        void HastaneListesi()
        {
            vt.baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Hastaneler", vt.baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["hastaneAdi"].ToString());
            }
            oku.Close();
            vt.baglanti.Close();
        }

        private void HekimBilgileriniGuncelle_Load(object sender, EventArgs e)
        {
            HekimListesi();
            HastaneListesi();
            timer1.Start();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            label5.Text = listView1.SelectedItems[0].Text;
            label6.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label5.Text == "---" || label6.Text == "---")
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = "";
            string hastane = "";
            adsoyad = textBox1.Text;
            hastane = comboBox1.Text;
            Filtre(adsoyad, hastane);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçilen Hekim Kaydını Silme İstiyor musunuz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] sutunlar = {"resim" };
                string silinecekVeri = vt.veri_cek("Hekimler",sutunlar,"id="+label5.Text);
                string[] degerler = silinecekVeri.Split('$');
                //MessageBox.Show(degerler[0]);
                bool durum = vt.sil("Hekimler", "id=" + label5.Text);
                if (durum == true)
                {
                    File.Delete("resimler/" + degerler[0]);
                    MessageBox.Show("Hekim Kaydı Başarıyla Silindi","Bilgi");
                    label5.Text = "---";
                    label6.Text = "---";
                    listView1.Items.Clear();
                    HekimListesi();
                }
                else
                {
                    MessageBox.Show("Hekim Kaydı Silinirken Bir Hata Oluştu !","Hata");
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HekimUpdateProcess form = new HekimUpdateProcess();
            form.label12.Text = label5.Text;
            form.ShowDialog();
        }
    }
}
