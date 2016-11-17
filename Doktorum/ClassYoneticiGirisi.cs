using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Doktorum
{
    class ClassYoneticiGirisi
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");

        string kullanici;
        string parola;
        string adsoyad;
        public string username
        {
            get
            {
                return kullanici;
            }
            set
            {
                this.kullanici = value;
            }
        }
        public string password
        {
            get
            {
                return parola;
            }
            set
            {
                this.parola = value;
            }
        }
        public ClassYoneticiGirisi()
        {

        }
        public ClassYoneticiGirisi(string kullaniciAdi,string parola)
        {
            this.kullanici = kullaniciAdi;
            this.parola = parola;
        }
        public bool Giris(string kullanici,string pass)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Admin WHERE kullaniciAdi='"+kullanici+"' AND parola='"+pass+"'",baglanti);
                OleDbDataReader oku = null;
                oku = komut.ExecuteReader();
                int sayac = 0;
                string adSoyad="";
                while(oku.Read())
                {
                    sayac++;
                    adSoyad = oku["adSoyad"].ToString();

                }
                if (sayac == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                    this.adsoyad = adSoyad;
                    username = "umit_dmrl";
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanı Hatası : " + ex.Message);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
