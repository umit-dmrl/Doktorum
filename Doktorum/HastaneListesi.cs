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

namespace Doktorum
{
    
    public partial class HastaneListesi : Form
    {
        
        public HastaneListesi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
        Veritabani vt = new Veritabani();
        void liste()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Hastaneler", baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem list = new ListViewItem(oku["id"].ToString());
                list.SubItems.Add(oku["hastaneAdi"].ToString());
                list.SubItems.Add(oku["hastaneTuru"].ToString());
                list.SubItems.Add(oku["hastaneTel"].ToString());
                list.SubItems.Add(oku["hastaneFax"].ToString());
                list.SubItems.Add(oku["hastaneEmail"].ToString());
                list.SubItems.Add(oku["hastaneWeb"].ToString());
                list.SubItems.Add(oku["hastaneAdres"].ToString());
                listView1.Items.Add(list);
            }
            baglanti.Close();
        }
        void filtre(string hastane_adi, string il)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Hastaneler where hastaneAdi like '%"+hastane_adi+"%' or hastane_il like '%"+il+"%'", baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem list = new ListViewItem(oku["id"].ToString());
                list.SubItems.Add(oku["hastaneAdi"].ToString());
                list.SubItems.Add(oku["hastaneTuru"].ToString());
                list.SubItems.Add(oku["hastaneTel"].ToString());
                list.SubItems.Add(oku["hastaneFax"].ToString());
                list.SubItems.Add(oku["hastaneEmail"].ToString());
                list.SubItems.Add(oku["hastaneWeb"].ToString());
                list.SubItems.Add(oku["hastaneAdres"].ToString());
                listView1.Items.Add(list);
            }
            baglanti.Close();
        }

        private void HastaneListesi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
            button3.Enabled = false;
            liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            liste();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            label4.Text = listView1.SelectedItems[0].Text;
            label6.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Text == "---" || label6.Text == "---")
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

        private void button2_Click(object sender, EventArgs e)
        {
            HastaneGuncelle form = new HastaneGuncelle();
            string[] sutunlar = { "id", "hastaneAdi", "hastaneTuru", "hastaneTel", "hastaneFax", "hastane_il", "hastaneAdres", "hastaneEmail", "hastaneWeb", "hastaneGoogleMaps" };
            
            string gelen = vt.veri_cek("Hastaneler", sutunlar,"id="+label4.Text);
            string[] veriler = gelen.Split('$');
            string hastaneAdi="", hastaneTuru="", hastaneTel="", hastaneFax="", hastane_il="", hastaneAdres="", hastaneEmail="", hastaneWeb="", hastaneGoogleMaps="";
            for (int i = 0; i < veriler.Length - 1; i++)
            {
                hastaneAdi = veriler[1];
                hastaneTuru = veriler[2];
                hastaneTel = veriler[3];
                hastaneFax = veriler[4];
                hastane_il = veriler[5];
                hastaneAdres = veriler[6];
                hastaneEmail = veriler[7];
                hastaneWeb = veriler[8];
                hastaneGoogleMaps = veriler[9];
            }
            form.label1.Text = label4.Text;
            form.textBox1.Text = hastaneAdi;
            form.textBox2.Text = hastaneTel;
            form.textBox3.Text = hastaneFax;
            form.textBox4.Text = hastaneEmail;
            form.textBox5.Text = hastaneWeb;
            form.comboBox1.Text = hastane_il;
            form.comboBox2.Text = hastaneTuru;
            form.richTextBox1.Text = hastaneAdres;
            //form.richTextBox2.Text = hastaneGoogleMaps;
            form.lblFileName.Text = hastaneGoogleMaps;

            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string hastane_adi = textBox1.Text;
            string il = comboBox1.Text;
            filtre(hastane_adi, il);
            label4.Text = "---";
            label6.Text = "---";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğine Emin misin?","Uyarı",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
            {
                bool durum = vt.sil("Hastaneler", "id=" + label4.Text);
                if (durum == true)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi");
                    label4.Text = "---";
                    label6.Text = "---";
                    liste();
                }
                else
                {
                    MessageBox.Show("Kayıt Silinirken Bir Hata Oluştu !","Hata");
                }
            }
        }
    }
}
