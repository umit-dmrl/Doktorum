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
    public partial class PoliklinikAtama : Form
    {
        public PoliklinikAtama()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
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
            OleDbCommand komut = new OleDbCommand("select * from Hastaneler where hastaneAdi like '%" + hastane_adi + "%' or hastane_il like '%" + il + "%'", baglanti);
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
        private void PoliklinikAtama_Load(object sender, EventArgs e)
        {
            liste();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Text == "---" || label6.Text == "---")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            label4.Text = listView1.SelectedItems[0].Text;
            label6.Text = listView1.SelectedItems[0].SubItems[1].Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            PoliklinikEkleGuncelle form = new PoliklinikEkleGuncelle();
            form.label3.Text = label4.Text;
            form.label4.Text = label6.Text;
            form.ShowDialog();
        }
    }
}
