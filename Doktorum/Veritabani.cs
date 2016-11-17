using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Doktorum
{
    class Veritabani
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db.accdb");
        public bool ekle(string tabloAdi,string[] sutunlar,string[] degerler)
        {
               try
               {
                    string strSutunlar = "";
                    for (int i = 0; i < sutunlar.Length; i++)
                    {
                        if (i == sutunlar.Length - 1)
                        {
                            strSutunlar += sutunlar[i];
                        }
                        else
                        {
                            strSutunlar += sutunlar[i] + ",";
                        }
                    }
                    string strDegerler = "";
                    for (int i = 0; i < degerler.Length; i++)
                    {
                        if (i == degerler.Length - 1)
                        {
                            strDegerler += "'"+degerler[i]+"'";
                        }
                        else
                        {
                            strDegerler += "'" + degerler[i]+"'" + ",";
                        }
                    }
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into "+tabloAdi+" ("+strSutunlar+") values ("+strDegerler+")", baglanti);
                    komut.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    baglanti.Close();
                }
        }
        public bool RandevuSaatiEkle(string secilen_saat, string hastaneID, string hekimID, string tarih)
        {
            try
            {
                string[] times_hours = { "09:00_09:15", "09:15_09:30", "09:30_09:45", "09:45_10:00", "10:00_10:15", "10:15_10:30", "10:30_10:45", "10:45_11:00", "11:00_11:15", "11:15_11:30", "11:30_11:45", "11:45_12:00", "13:00_13:15", "13:15_13:30", "13:30_13:45", "13:45_14:00", "14:00_14:15", "14:15_14:30", "14:30_14:45", "14:45_15:00" };
                string[] times = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10", "s11", "s12", "s13", "s14", "s15", "s16", "s17", "s18", "s19", "s20" };
                string[] timesValue = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

                int indis = -1;
                for (int i = 0; i < times_hours.Length; i++)
                {
                    if (times_hours[i] == secilen_saat)
                    {
                        indis = i;
                    }
                }
                timesValue[indis] = "1";
                string eklenecek_sutun = times[indis];
                string str_times = "";
                for (int i = 0; i < times.Length; i++)
                {
                    if (i == times.Length - 1)
                    {
                        str_times += times[i];
                    }
                    else
                    {
                        str_times += times[i] + ",";
                    }
                }
                string str_values = "";
                for (int i = 0; i < timesValue.Length; i++)
                {
                    if (i == timesValue.Length - 1)
                    {
                        str_values += "'" + timesValue[i] + "'";
                    }
                    else
                    {
                        str_values += "'" + timesValue[i] + "'" + ",";
                    }
                }

                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into TestRandevuSaatleri (hastaneID,hekimID,tarih,s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,s17,s18,s19,s20) values ('" + hastaneID + "','" + hekimID + "','" + tarih + "'," + str_values + ")", baglanti);
                    komut.ExecuteNonQuery();
                    return true;
                }
                catch(OleDbException ex)
                {
                    MessageBox.Show(ex.Message,"Veri Tabanı Hatası !");
                    return false;
                }
                finally
                {
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Listeden Bir Saat Seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool guncelle(string tabloAdi,string[] sutunlar,string[] degerler,string kosul)
        {
            try
            {
                string strKomut = "";
                for (int i = 0; i < sutunlar.Length; i++)
                {
                    if (i == sutunlar.Length - 1)
                    {
                        strKomut += sutunlar[i] + "='" + degerler[i] + "'";
                    }
                    else
                    {
                        strKomut += sutunlar[i] + "='" + degerler[i] + "'" + ",";
                    }
                }
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("update "+tabloAdi+" set "+strKomut+" where "+kosul, baglanti);
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }
        public bool sil(string tabloAdi, string kosul)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from "+tabloAdi+" where "+kosul, baglanti);
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }
        public string veri_cek(string tabloAdi,string[] sutunlar,string kosul)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from "+tabloAdi+" where "+kosul,baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            string str_veriler = "";
            
                while (oku.Read())
                {
                    for (int i = 0; i < sutunlar.Length; i++)
                    {
                        str_veriler += oku[sutunlar[i]].ToString()+"$";
                    }
                }
                oku.Close();
            baglanti.Close();
            return str_veriler;
        }
        public bool KayitVarMi(string tabloAdi,string sutunAdi,string kosul)
        {
            bool durum=false;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from "+tabloAdi+" where "+kosul,baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku[sutunAdi].ToString() == "")
                {
                    durum = false;
                }
                else
                {
                    durum = true;
                }
            }
            baglanti.Close();
            oku.Close();
            return durum; 
        }
        public string ComboBoxVeriCek(string tabloAdi,string cekilecekSutun)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from "+tabloAdi,baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            string veri = "";
            while (oku.Read())
            {
                veri += oku[cekilecekSutun].ToString()+"-";
            }
            baglanti.Close();
            return veri;
        }
        public ListView listele(string tabloAdi,string[] sutunlar)
        {
            ListView l = new ListView();
            OleDbCommand komut = new OleDbCommand("select * from "+tabloAdi, baglanti);
            baglanti.Open();
            
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            ListViewItem liste = null;
            
            while (oku.Read())
            {
                liste = new ListViewItem(oku["id"].ToString());
                liste.SubItems.Add(oku["hastaneAdi"].ToString());
                liste.SubItems.Add(oku["hastane_il"].ToString());
                liste.SubItems.Add(oku["hastaneTel"].ToString());
                liste.SubItems.Add(oku["hastaneFax"].ToString());
                l.Items.Add(liste);
                /*foreach (string sutun in sutunlar)
                {
                    liste.SubItems.Add(oku[sutun].ToString());
                }*/
            }
            baglanti.Close();
            return l;
            
        }

    }
}
