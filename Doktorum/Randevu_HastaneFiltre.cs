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
    public partial class Randevu_HastaneFiltre : Form
    {
        private RandevuAl randevuAl;
        public Randevu_HastaneFiltre()
        {
            InitializeComponent();
        }
        public Randevu_HastaneFiltre(RandevuAl randevu_al)
        {
            InitializeComponent();
            this.randevuAl = randevu_al;
        }
        
        Veritabani vt = new Veritabani();
        void filtrele(string kelime,string il)
        {
            if (il == "Seçiniz")
            {
                il = "*";
            }
            vt.baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select * from Hastaneler where hastaneAdi like '%"+kelime+"%' and hastane_il like '%"+il+"%'",vt.baglanti);
            OleDbDataReader oku = null;
            oku = sorgu.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                ListViewItem liste = new ListViewItem(oku["id"].ToString());
                liste.SubItems.Add(oku["hastaneAdi"].ToString());
                liste.SubItems.Add(oku["hastaneTuru"].ToString());
                liste.SubItems.Add(oku["hastaneTel"].ToString());
                liste.SubItems.Add(oku["hastaneFax"].ToString());
                liste.SubItems.Add(oku["hastane_il"].ToString());
                liste.SubItems.Add(oku["hastaneAdres"].ToString());
                liste.SubItems.Add(oku["hastaneEmail"].ToString());
                liste.SubItems.Add(oku["hastaneWeb"].ToString());
                listView1.Items.Add(liste);
                sayac++;
            }
            vt.baglanti.Close();
            if (sayac == 0)
            {
                MessageBox.Show("Aradığınız Koşullarda Bir Sonuç Bulunamadı !\n Şimdi Koşulları Değiştirerek Tekrar Deneyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                lblAramaDurumu.Text = sayac + " Adet Kayıt Bulundu...";
            }
        }
        private void Randevu_HastaneFiltre_Load(object sender, EventArgs e)
        {
            string hastane_adi = lblHastaneAdi.Text;
            string il = lbl_il.Text;
            //string[] sutunlar = { "id", "hastaneAdi", "hastaneTuru", "hastaneTel", "hastaneFax", "hastane_il", "hastaneAdres", "hastaneEmail", "hastaneWeb" };
            filtrele(hastane_adi,il);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].Text;
            string adi = listView1.SelectedItems[0].SubItems[1].Text;
            string turu = listView1.SelectedItems[0].SubItems[2].Text;
            string tel = listView1.SelectedItems[0].SubItems[3].Text;
            string fax = listView1.SelectedItems[0].SubItems[4].Text;
            string il = listView1.SelectedItems[0].SubItems[5].Text;
            string adres = listView1.SelectedItems[0].SubItems[6].Text;
            string email = listView1.SelectedItems[0].SubItems[7].Text;
            string web = listView1.SelectedItems[0].SubItems[8].Text;

            lblID.Text = id;
            lblHastaneAd.Text = adi;
            lblHastaneTuru.Text = turu;
            lblHastaneTel.Text = tel;
            lblHastaneFax.Text = fax;
            lblHastaneIl.Text = il;
            richTextBox1.Text = adres;
            lblHastaneEmail.Text = email;
            lblHastaneWeb.Text = web;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "---" || lblID.Text == "")
            {
                MessageBox.Show("Bir Hastane Seçimi Yapmalısınız !\nSeçtiğiniz Hastane Bilgileri Yan Kısımda Görüntülenir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RandevuAl form = new RandevuAl();
                randevuAl.lblHastaneID.Text = lblID.Text;
                randevuAl.lblHastaneAdi.Text = lblHastaneAd.Text;
                this.Close();
            }
        }
    }
}
