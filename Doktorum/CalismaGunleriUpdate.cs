using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doktorum
{
    public partial class CalismaGunleriUpdate : Form
    {
        public CalismaGunleriUpdate()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void CalismaGunleriUpdate_Load(object sender, EventArgs e)
        {

            string[] sutunlar = { "adsoyad", "dtarih", "egitim", "hastane", "uzmanlik", "resim" };
            string veriler = vt.veri_cek("Hekimler", sutunlar, "id=" + lblID.Text);
            string[] degerler = veriler.Split('$');
            for (int i = 0; i < degerler.Length - 1; i++)
            {
                lblAdSoyad.Text = degerler[0].ToString();
                lblDtarih.Text = degerler[1].ToString();
                lblEgitim.Text = degerler[2].ToString();
                lblHastane.Text = degerler[3].ToString();
                lblUzmanlik.Text = degerler[4].ToString();
                pictureBox1.ImageLocation = "resimler/" + degerler[5].ToString();
            }
            //Daha önceden kayıt eklenip eklenmediği kontrol ediliyor
            bool KayitKontrol = vt.KayitVarMi("CalismaGunleri", "pazartesi", "hekim_id='"+lblID.Text+"'");
            if (KayitKontrol == true)
            {
                label14.Text = "Kayıt Var";
            }
            else
            {
                label14.Text = "Kayıt Daha Önce Eklenmemiş.";
            }
            //Çalışma günleri varsa ilgili alanlarda günlerin gösterilmesi
            if (label14.Text == "Kayıt Var")
            {
                string[] gunler = { "pazartesi", "sali", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };
                string gelenGunler = vt.veri_cek("CalismaGunleri", gunler, "hekim_id='" + lblID.Text+"'");
                string[] gunDeger = gelenGunler.Split('$');
                for (int i = 0; i < gunDeger.Length - 1; i++)
                {
                    comboBox1.Text = gunDeger[0].ToString();
                    comboBox2.Text = gunDeger[1].ToString();
                    comboBox3.Text = gunDeger[2].ToString();
                    comboBox4.Text = gunDeger[3].ToString();
                    comboBox5.Text = gunDeger[4].ToString();
                    comboBox6.Text = gunDeger[5].ToString();
                    comboBox7.Text = gunDeger[6].ToString();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sutunlar = {"hekim_id","pazartesi","sali","carsamba","persembe","cuma","cumartesi","pazar" };
            string[] degerler = { lblID.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, comboBox7.Text };
            if (label14.Text == "Kayıt Daha Önce Eklenmemiş.")
            {
                //Kayıt ekleme yap
                bool durum = vt.ekle("CalismaGunleri", sutunlar, degerler);
                if (durum == true)
                {
                    MessageBox.Show("Kayıt İşlemi Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label14.Text = "Kayıt Var";
                }
                else
                {
                    MessageBox.Show("Kayıt Yapılırken Bir Hata Oluştu !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                //Güncelleme yap
                bool durum = vt.guncelle("CalismaGunleri", sutunlar, degerler, "hekim_id='" + lblID.Text+"'");
                if (durum == true)
                {
                    MessageBox.Show("Güncelleme İşlemi Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme Yapılırken Bir Hata Oluştu !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
