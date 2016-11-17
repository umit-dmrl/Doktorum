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
    public partial class PoliklinikEkleGuncelle : Form
    {
        public PoliklinikEkleGuncelle()
        {
            InitializeComponent();
        }
        
        
        bool atama_durumu=false;
        private void PoliklinikEkleGuncelle_Load(object sender, EventArgs e)
        {
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
            try
            {
                
                baglanti.Open();
                OleDbCommand sorgula = new OleDbCommand("select * from Poliklinikler where hastane_id="+"'"+label3.Text+"'",baglanti);
                OleDbDataReader oku = null;
                oku = sorgula.ExecuteReader();
                int sayac = 0;
                string veriler = "";
                while (oku.Read())
                {
                    sayac++;
                    veriler += oku["poliklinikler"].ToString();
                }
                if (sayac == 0)
                {
                    label5.Text = "Bu Hastaneye Daha Önce Poliklinik Ataması Yapılmamış !";
                    atama_durumu = false;
                }
                else
                {
                    atama_durumu = true;
                    label5.Text = "Bu Hastane İçin Poliklinik Ataması Yapılmış.";
                    string[] degerler = veriler.Split('-');
                    for (int i = 0; i < degerler.Length; i++)
                    {
                        if (degerler[i].ToString() == "Beyin Cerrahisi")
                        {
                            checkedListBox1.SetItemChecked(0, true);
                        }
                        else if (degerler[i].ToString() == "Cildiye")
                        {
                            checkedListBox1.SetItemChecked(1, true);
                        }
                        else if (degerler[i].ToString() == "Çocuk Cerrahisi")
                        {
                            checkedListBox1.SetItemChecked(2, true);
                        }
                        else if (degerler[i].ToString() == "Çocuk Hastalıkları")
                        {
                            checkedListBox1.SetItemChecked(3, true);
                        }
                        else if (degerler[i].ToString() == "Dahiliye")
                        {
                            checkedListBox1.SetItemChecked(4, true);
                        }
                        else if (degerler[i].ToString() == "Fizik Tedavi")
                        {
                            checkedListBox1.SetItemChecked(5, true);
                        }
                        else if (degerler[i].ToString() == "Göğüs Cerrahisi")
                        {
                            checkedListBox1.SetItemChecked(6, true);
                        }
                        else if (degerler[i].ToString() == "Göğüs Hastalıkları")
                        {
                            checkedListBox1.SetItemChecked(7, true);
                        }
                        else if (degerler[i].ToString() == "Kadın Doğum")
                        {
                            checkedListBox1.SetItemChecked(8, true);
                        }
                        else if (degerler[i].ToString() == "Kalp Damar Cerrahisi")
                        {
                            checkedListBox1.SetItemChecked(9, true);
                        }
                        else if (degerler[i].ToString() == "Kalp Damar Hastalıkları")
                        {
                            checkedListBox1.SetItemChecked(10, true);
                        }
                        else if (degerler[i].ToString() == "Onkoloji")
                        {
                            checkedListBox1.SetItemChecked(11, true);
                        }
                        else if (degerler[i].ToString() == "Ortopedi")
                        {
                            checkedListBox1.SetItemChecked(12, true);
                        }
                        else if (degerler[i].ToString() == "Radyoloji")
                        {
                            checkedListBox1.SetItemChecked(13, true);
                        }
                        else if (degerler[i].ToString() == "Sinir Hastalıkları")
                        {
                            checkedListBox1.SetItemChecked(14, true);
                        }
                        else if (degerler[i].ToString() == "Üroloji")
                        {
                            checkedListBox1.SetItemChecked(15, true);
                        }
                        
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata");
                ex.Message.ToString();
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani vt = new Veritabani();
            
                string veriler = "";
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        if (i != checkedListBox1.CheckedItems.Count - 1)
                        {
                            veriler += checkedListBox1.CheckedItems[i].ToString() + "-";
                        }
                        else
                        {
                            veriler += checkedListBox1.CheckedItems[i].ToString();
                        }
                    }
                    
                    if (atama_durumu == true)
                    {
                        string[] sutunlar = { "poliklinikler" };
                        string[] degerler = { veriler };
                        bool durum = vt.guncelle("Poliklinikler", sutunlar, degerler, "hastane_id='" + label3.Text + "'");
                        if (durum == true)
                        {
                            MessageBox.Show("Seçilen Poliklinikler Ataması Güncellendi", "Bilgi");
                            label5.Text = "Bu Hastane İçin Poliklinik Ataması Yapılmış.";
                            atama_durumu = true;
                        }
                        else
                        {
                            MessageBox.Show("Atama Güncellenirken Bir Hata Oluştu !", "Uyarı");
                            atama_durumu = false;
                        }
                    }
                    else
                    {
                        string[] sutunlar = { "hastane_id","poliklinikler" };
                        string[] degerler = { label3.Text,veriler };
                        bool durum = vt.ekle("Poliklinikler", sutunlar, degerler);
                        if (durum == true)
                        {
                            MessageBox.Show("Seçilen Poliklinikler Ataması Yapıldı", "Bilgi");
                            label5.Text = "Bu Hastane İçin Poliklinik Ataması Yapılmış.";
                            atama_durumu = true;
                        }
                        else
                        {
                            MessageBox.Show("Atama Yapılırken Bir Hata Oluştu !", "Uyarı");
                            atama_durumu = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen listeden en az 1 eleman seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
