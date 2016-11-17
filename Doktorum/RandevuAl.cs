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
    public partial class RandevuAl : Form
    {
        Veritabani vt = new Veritabani();
        public RandevuAl()
        {
            InitializeComponent();
        }
        void UygunSaatleriBul(string hastaneID,string hekimID,string tarih)
        {
            listBox1.Items.Clear();
            vt.baglanti.Open();
            string[] times_hours = { "09:00_09:15", "09:15_09:30", "09:30_09:45", "09:45_10:00", "10:00_10:15", "10:15_10:30", "10:30_10:45", "10:45_11:00", "11:00_11:15", "11:15_11:30", "11:30_11:45", "11:45_12:00", "13:00_13:15", "13:15_13:30", "13:30_13:45", "13:45_14:00", "14:00_14:15", "14:15_14:30", "14:30_14:45", "14:45_15:00" };
            string[] times = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10", "s11", "s12", "s13", "s14", "s15", "s16", "s17", "s18", "s19", "s20" };

            OleDbCommand komut = new OleDbCommand("SELECT * FROM TestRandevuSaatleri WHERE hastaneID='" + hastaneID + "' AND hekimID='" + hekimID + "' AND tarih='" + tarih + "'", vt.baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            string dolu_saatler = "";
            while (oku.Read())
            {
                for (int i = 0; i < times.Length; i++)
                {
                    if (oku[times[i]].ToString() == "1")
                    {
                        //listBox1.Items.Add(times_hours[i].ToString());
                        dolu_saatler += times_hours[i].ToString() + "+";
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            vt.baglanti.Close();
            string[] dolu_saat_deger = dolu_saatler.Split('+');
            string[] sonuc = times_hours.Except(dolu_saat_deger).ToArray();
            for (int i = 0; i < sonuc.Length; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }
        }
        void HekimBul(string hastaneAdi)
        {
            listHekimler.Items.Clear();
            vt.baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select * from Hekimler where hastane like '%"+hastaneAdi+"%'", vt.baglanti);
            OleDbDataReader oku = null;
            oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["id"].ToString());
                item.SubItems.Add(oku["adsoyad"].ToString());
                item.SubItems.Add(oku["uzmanlik"].ToString());
                item.SubItems.Add(oku["hastane"].ToString());
                listHekimler.Items.Add(item);
            }
            oku.Close();
            vt.baglanti.Close();
        }
        void BransBul(string hastaneID)
        {
            combobox_poliklinik.Items.Clear();
            string[] sutunlar = { "poliklinikler" };
            string poliklinikler = vt.veri_cek("Poliklinikler", sutunlar, "hastane_id='" + hastaneID + "'");
            string[] degerler = poliklinikler.Split('-');
            for (int i = 0; i < degerler.Length - 1; i++)
            {
                combobox_poliklinik.Items.Add(degerler[i].ToString());
            }
        }
        void BransaGoreHekimFiltre(string bransAdi,string hastaneAdi)
        {
            listHekimler.Items.Clear();
            vt.baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select * from Hekimler where uzmanlik='"+bransAdi+"' and hastane='"+hastaneAdi+"'",vt.baglanti);
            OleDbDataReader oku = null;
            oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["id"].ToString());
                item.SubItems.Add(oku["adsoyad"].ToString());
                item.SubItems.Add(oku["hastane"].ToString());
                item.SubItems.Add(oku["uzmanlik"].ToString());
                listHekimler.Items.Add(item); 
            }
            oku.Close();
            vt.baglanti.Close();
        }
        //ingilizce gün isimlerini alıp türkçe olarak geri döndüren fonksiyon
        string GunCevir(string GunAdi)
        {
            if (GunAdi == "Monday")
            {
                return "Pazartesi";
            }
            else if (GunAdi == "Tuesday")
            {
                return "Salı";
            }
            else if (GunAdi == "Wednesday")
            {
                return "Çarşamba";
            }
            else if (GunAdi == "Thursday")
            {
                return "Perşembe";
            }
            else if (GunAdi == "Friday")
            {
                return "Cuma";
            }
            else if (GunAdi == "Saturday")
            {
                return "Cumartesi";
            }
            else if (GunAdi == "Sunday")
            {
                return "Pazar";
            }
            else
            {
                return "Tanımsız Gün";
            }
        }
        //Günlerin enum karşılıkları için sayısal çevirme
        int EnumGunCevir(string GunAdi)
        {
            if (GunAdi == "Pazartesi")
            {
                return 0;
            }
            else if (GunAdi == "Salı")
            {
                return 1;
            }
            else if (GunAdi == "Çarşamba")
            {
                return 2;
            }
            else if (GunAdi == "Perşembe")
            {
                return 3;
            }
            else if (GunAdi == "Cuma")
            {
                return 4;
            }
            else if (GunAdi == "Cumartesi")
            {
                return 5;
            }
            else if (GunAdi == "Pazar")
            {
                return 6;
            }
            else
            {
                return -1;
            }
        }
        void Temizle()
        {
            grpTarihSaat.Enabled = false;
            /////
            lblSecilenHekimID.Text = "---";
            lblSecilenHekimAdi.Text = "---";
            lblSecilenHekimBrans.Text = "---";
            combobox_poliklinik.Text = "";
            grpHekimBrans.Visible = false;
            /////
            lblHastaneID.Text = "---";
            lblHastaneAdi.Text = "---";
            grpHastaneBilgileri.Enabled = false;
            /////
            txtAdSoyad.Text = "";
            txtHastaneArama.Text = "";
            txtKimlikNo.Text = "";
            tarih_sec.Text = "";
            timer2.Stop();
        }
        private void RandevuAl_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            timer1.Start();
            lblTarih.Text = DateTime.Now.ToShortDateString();
            label16.Text = DateTime.Now.ToShortDateString();
            tarih_sec.Text = DateTime.Now.Year.ToString();
            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i > 1940 ; i--)
            {
                tarih_sec.Items.Add(i);
            }
            listBox1.Visible = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            if (lblHastaneID.Text == "" || lblHastaneID.Text == "---")
            {
                btnAdimHekimBransSecimi.Enabled = false;
            }
            else
            {
                btnAdimHekimBransSecimi.Enabled = true;
            }
            if (lblSecilenHekimID.Text == "---" || lblSecilenHekimID.Text == "" || lblSecilenHekimAdi.Text == "---" || lblSecilenHekimAdi.Text == "")
            {
                btnAdimTarihSaat.Enabled = false;
            }
            else
            {
                btnAdimTarihSaat.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevu_HastaneFiltre form = new Randevu_HastaneFiltre(this);
            form.lblHastaneAdi.Text = txtHastaneArama.Text;
            form.lbl_il.Text = il_sec.Text;
            form.ShowDialog();
            grpHekimBrans.Visible = false;
            lblSecilenHekimID.Text = "---";
            lblSecilenHekimAdi.Text = "---";
            lblSecilenHekimBrans.Text = "---";
            grpTarihSaat.Enabled = false;
        }

        private void btnAdimHekimBransSecimi_Click(object sender, EventArgs e)
        {
            grpHekimBrans.Visible = true;
            BransBul(lblHastaneID.Text);
            HekimBul(lblHastaneAdi.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BransaGoreHekimFiltre(combobox_poliklinik.Text, lblHastaneAdi.Text);
        }

        private void btnAdimTarihSaat_Click(object sender, EventArgs e)
        {
            grpTarihSaat.Enabled = true;
            UygunSaatleriBul(lblHastaneID.Text, lblSecilenHekimID.Text, lblTarih.Text);
            string[] kabul_gunleri = lblHastaKabulGunleri.Text.Split(',');
            int sayac = 0;
            for (int i = 0; i < kabul_gunleri.Length-1; i++)
            {
                if (label15.Text == kabul_gunleri[i])
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                listBox1.Visible = false;
                label18.Text = "Hekimin Hasta Kabul Günü Değil !";
            }
            else
            {
                listBox1.Visible = true;
                label18.Text = "";
            }
        }

        private void listHekimler_Click(object sender, EventArgs e)
        {
            lblSecilenHekimID.Text = listHekimler.SelectedItems[0].Text;
            lblSecilenHekimAdi.Text = listHekimler.SelectedItems[0].SubItems[1].Text;
            lblSecilenHekimBrans.Text = listHekimler.SelectedItems[0].SubItems[2].Text;
            string[] sutunlar = { "pazartesi", "sali", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };
            string[] gunler = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar" };
            string gelenVeri = vt.veri_cek("CalismaGunleri", sutunlar, "hekim_id='" + lblSecilenHekimID.Text + "'");
            string[] degerler = gelenVeri.Split('$');
            string hasta_kabul_gunleri = "";
            for (int i = 0; i < degerler.Length - 1; i++)
            {
                if (degerler[i] == "Hasta Kabul Günü")
                {
                    hasta_kabul_gunleri += gunler[i]+",";
                }
            }
            lblHastaKabulGunleri.Text = hasta_kabul_gunleri;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnBilgiKontrol_Click(object sender, EventArgs e)
        {
            //Boş alan kontrol işlemleri
            if (txtKimlikNo.Text == "" || txtAdSoyad.Text=="")
            {
                MessageBox.Show("Lütfen Hasta Bilgilerini Kotrol Edin Ve Tüm Boş Alanları Doldurun !","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (lblHastaneID.Text == "" || lblHastaneID.Text=="---")
            {
                MessageBox.Show("Bir Hastane Seçimi Yapılmamış Gibi Görünüyor !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblSecilenHekimID.Text == "" || lblSecilenHekimID.Text == "---")
            {
                MessageBox.Show("Bir Hekim Seçimi Yapılmamış Gibi Görünüyor !","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (tarih_sec.Text == "")
            {
                MessageBox.Show("Hastanın Doğum Tarihi Boş Gibi Görünüyor ! Bu Alanı Doldurunuz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnRandevuOlustur.Enabled = true;
            }
            if (listBox1.SelectedIndex<=0)
            {
                btnRandevuOlustur.Enabled = false;
                MessageBox.Show("Lütfen Bir Randevu Saati Seçiniz !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                btnRandevuOlustur.Enabled = true;
            }
            //Hekimin çalışma günleri uygunluğu
            string[] sutunlar = { "pazartesi","sali","carsamba","persembe","cuma","cumartesi","pazar" };
            string gelenVeri = vt.veri_cek("CalismaGunleri", sutunlar, "hekim_id='"+lblSecilenHekimID.Text+"'");
            string[] degerler = gelenVeri.Split('$');
            int GunInt = EnumGunCevir(label15.Text);
            string HekimGunDurumu = degerler[GunInt].ToString();

            if (HekimGunDurumu == "İzin Günü")
            {
                MessageBox.Show("Seçtiğiniz Gün Hekimin : "+HekimGunDurumu+"\nBaşka Bir Gün Seçiniz !");
                btnRandevuOlustur.Enabled = false;
            }
            else if (HekimGunDurumu == "Ameliyat Günü")
            {
                MessageBox.Show("Seçtiğiniz Gün Hekimin : " + HekimGunDurumu);
                btnRandevuOlustur.Enabled = false;
            }
            else if (HekimGunDurumu == "Yoğun Bakımda Görevli")
            {
                MessageBox.Show("Seçtiğiniz Gün Hekimin : " + HekimGunDurumu);
                btnRandevuOlustur.Enabled = false;
            }
            else if (HekimGunDurumu == "Acilde Görevli")
            {
                MessageBox.Show("Seçtiğiniz Gün Hekimin : " + HekimGunDurumu);
                btnRandevuOlustur.Enabled = false;
            }
            else
            {
                btnRandevuOlustur.Enabled = true;
            }
            

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            btnBilgiKontrol.Enabled = false;
            btnRandevuOlustur.Enabled = false;
            //Hekimin çalışma günleri uygunluğu
            string[] sutunlar = { "pazartesi", "sali", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };
            string gelenVeri = vt.veri_cek("CalismaGunleri", sutunlar, "hekim_id='" + lblSecilenHekimID.Text + "'");
            string[] degerler = gelenVeri.Split('$');
            int GunInt = EnumGunCevir(label15.Text);
            string HekimGunDurumu = degerler[GunInt].ToString();

            if (HekimGunDurumu == "İzin Günü")
            {
                btnRandevuOlustur.Enabled = false;
            }
            else if (HekimGunDurumu == "Ameliyat Günü")
            {
                btnRandevuOlustur.Enabled = false;
            }
            else if (HekimGunDurumu == "Yoğun Bakımda Görevli")
            {
                btnRandevuOlustur.Enabled = false;
            }
            else if (HekimGunDurumu == "Acilde Görevli")
            {
                btnRandevuOlustur.Enabled = false;
            }
        }
        //Randevu oluşturma işlemleri
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {

            try
            {
                //Randevular tablosuna veri kaydetme
                Random rnd = new Random();
                string HastaneID = lblHastaneID.Text;
                string HekimID = lblSecilenHekimID.Text;
                //string RandevuTarihi = lblSecilenTarih.Text;
                string RandevuTarihi = label16.Text;
                //string RandevuSaati = SaatSec.Text;
                string RandevuSaati = listBox1.SelectedItem.ToString();
                string RandevuNo = rnd.Next(0, 999999).ToString();
                string HastaAdı = txtAdSoyad.Text;
                string KimlikNo = txtKimlikNo.Text;
                string DogumTarihi = tarih_sec.Text;
                Randevu randevu = new Randevu(HastaneID, HekimID, RandevuTarihi, RandevuSaati, RandevuNo, HastaAdı, KimlikNo, DogumTarihi);
                if (MessageBox.Show("Bu Randevuyu Oluşturmak İstiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] sutunlar = { "randevuNumarasi", "kimlikNumarasi", "randevuTarihi", "saat", "adsoyad", "dogumTarihi", "hastane_id", "hekim_id", "bolum" };
                    string[] degerler = { randevu.randevuNumarasi, randevu.KimlikNo, randevu.randevuTarihi, randevu.randevuSaati, randevu.AdSoyad, randevu.DogumTarihi, randevu.hastaneID, randevu.hekimID, lblSecilenHekimBrans.Text };
                    string[] randevuSaatleriSutun = { "hastaneID", "hekimID", "tarih", RandevuSaati };
                    string[] randevuSaatiDegerleri = { randevu.hastaneID, randevu.hekimID, randevu.randevuTarihi, randevu.randevuSaati };
                    bool randevuSaatiEkleme = vt.RandevuSaatiEkle(randevu.randevuSaati, randevu.hastaneID, randevu.hekimID, randevu.randevuTarihi);
                    if (randevuSaatiEkleme == true)
                    {
                        MessageBox.Show("Randevu saatleri eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Randevu saati ekleme hatası");
                    }


                    bool durum = vt.ekle("Randevular", sutunlar, degerler);
                    if (durum == true)
                    {
                        bool state = vt.RandevuSaatiEkle(listBox1.SelectedItem.ToString(), randevu.hastaneID, randevu.hekimID, randevu.randevuTarihi);
                        if (state == false)
                        {
                            MessageBox.Show("Randevu Saati Kayıt Edilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        MessageBox.Show("Randevu Başarıyla Oluşturuldu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Randevu Oluşturulurken Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Bir Randevu Saati Seçin Ve Diğer Adımları Doldurun");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
                listBox1.Items.Clear();
                label16.Text = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                label15.Text = GunCevir(dateTimePicker1.Value.DayOfWeek.ToString());
                UygunSaatleriBul(lblHastaneID.Text, lblSecilenHekimID.Text, label16.Text);
                string[] kabul_gunleri = lblHastaKabulGunleri.Text.Split(',');
                int sayac = 0;
                for (int i = 0; i < kabul_gunleri.Length - 1; i++)
                {
                    if (label15.Text == kabul_gunleri[i])
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    listBox1.Visible = false;
                    label18.Text = "Hekimin Hasta Kabul Günü Değil !";
                }
                else
                {
                    listBox1.Visible = true;
                    label18.Text = "";
                }
            
            
        }


        

    }
}
