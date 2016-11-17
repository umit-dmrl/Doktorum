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
    public partial class CalismaGunleri : Form
    {
        public CalismaGunleri()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void HekimListesi()
        {
            vt.baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Hekimler", vt.baglanti);
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
        void Filtre(string adsoyad, string hastane)
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
            OleDbCommand komut = new OleDbCommand("select * from Hekimler where adsoyad like '%" + adsoyad + "%' or hastane like '%" + hastane + "%'", vt.baglanti);
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label5.Text == "---" || label6.Text == "---")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void CalismaGunleri_Load(object sender, EventArgs e)
        {
            timer1.Start();
            HekimListesi();
            HastaneListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtre(textBox1.Text, comboBox1.Text);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            label5.Text = listView1.SelectedItems[0].Text;
            label6.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalismaGunleriUpdate form = new CalismaGunleriUpdate();
            form.lblID.Text = label5.Text;
            form.ShowDialog();
        }
    }
}
