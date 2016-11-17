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
using System.Drawing.Printing;
using System.IO;
using Microsoft.Win32;
using System.Net;
using System.Net.Mail;

namespace Doktorum
{
    public partial class lblAdSoyad : Form
    {
        private HekimDetay form_hekimDetay;
        public lblAdSoyad()
        {
            InitializeComponent();
        }
        public lblAdSoyad(HekimDetay form)
        {
            InitializeComponent();
            this.form_hekimDetay = form;
        }
        Veritabani vt = new Veritabani();
        void Sorgula()
        {
            listView1.Items.Clear();
            lblSonuc.Text = "---";
            string kimlik_no = txtKimlikNo.Text;
            vt.baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Randevular where kimlikNumarasi='"+kimlik_no+"' order by id desc",vt.baglanti);
            OleDbDataReader oku = null;
            oku = komut.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["randevuNumarasi"].ToString());
                item.SubItems.Add(oku["randevuTarihi"].ToString());
                item.SubItems.Add(oku["saat"].ToString());
                item.SubItems.Add(oku["bolum"].ToString());
                item.SubItems.Add(oku["hekim_id"].ToString());
                item.SubItems.Add(oku["hastane_id"].ToString());
                listView1.Items.Add(item);
                sayac++;
            }
            vt.baglanti.Close();
            if (sayac == 0)
            {
                lblSonuc.Text = "Randevu Bulunamadı!";
                MessageBox.Show("Aradığınız Kimlik Bilgisine Ait Randevu Bulunamadı !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblSonuc.Text = txtKimlikNo.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text != "---")
            {
                btnHekimDetay.Enabled = true;
                btnHastaneDetay.Enabled = true;
                btnMailGonder.Enabled = true;
                string randevuNo = listView1.SelectedItems[0].Text;
                string[] sutunlar = { "randevuNumarasi", "randevuTarihi", "saat", "adsoyad", "dogumTarihi", "hastane_id", "hekim_id","bolum" };
                string veriler = vt.veri_cek("Randevular", sutunlar, "randevuNumarasi='" + randevuNo + "' and kimlikNumarasi='"+lblSonuc.Text+"'");
                string[] degerler = veriler.Split('$');
                lblIsımSoyisim.Text = degerler[3].ToString();
                lblDogumTarihi.Text = degerler[4].ToString();
                lblRandevuNo.Text = degerler[0].ToString();
                lblRandevuTarihi.Text = degerler[1].ToString();
                lblRandevuSaat.Text = degerler[2].ToString();
                lblBolum.Text = degerler[7].ToString();
                lblHastaneNo.Text = degerler[5].ToString();
                lblHekimNo.Text = degerler[6].ToString();

                //Hastane Bilgileri getir
                string[] hastaneSutun = { "hastaneAdi", "hastaneTuru", "hastane_il", "hastaneGoogleMaps" };
                string hastane_bilgi = vt.veri_cek("Hastaneler", hastaneSutun, "id=" + lblHastaneNo.Text);
                string[] hastane_degerleri = hastane_bilgi.Split('$');
                lblHastaneAdi.Text = hastane_degerleri[0].ToString();
                lblIl.Text = hastane_degerleri[2].ToString();
                lblHastaneTuru.Text = hastane_degerleri[1].ToString();
                
                //Hekim Bilgileri Getir
                string[] hekimSutun = {"adsoyad","uzmanlik","resim" };
                string hekim_bilgi = vt.veri_cek("Hekimler", hekimSutun, "id=" + lblHekimNo.Text);
                string[] hekim_degerleri = hekim_bilgi.Split('$');
                lblHekimAdi.Text = hekim_degerleri[0].ToString();
                lblUzmanlik.Text = hekim_degerleri[1].ToString();
                pictureBox1.ImageLocation = "resimler/" + hekim_degerleri[2].ToString();

                try
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                    if (key == null)
                    {
                        Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                        key.SetValue("ProgramızınAdı.exe", 9000, RegistryValueKind.DWord);
                        key.Flush();
                        key.Close();
                    }
                    else if (key.GetValue("Doktorum.exe") != (object)(9000))
                    {
                        key.SetValue("Doktorum.exe", 9000, RegistryValueKind.DWord);
                        key.Flush();
                        key.Close();
                    }
                }
                catch { }

                webBrowser1.ScriptErrorsSuppressed = true;
                string curDir = Directory.GetCurrentDirectory();
                this.webBrowser1.Url = new Uri(String.Format("file:///{0}/maps/"+hastane_degerleri[3]+".html", curDir));
            }
            
        }

        private static void OnPrintDocument(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, 20, 20, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string epostaAdresi="";
            epostaAdresi = txtEpostaAdresi.Text.Trim();
            if (epostaAdresi != "")
            {
                try
                {
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("umit.demirel94@gmail.com", "19741974x");
                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress("umit.demirel94@gmail.com", "Doktorum Randevu Sistemi");

                    mail.To.Add(txtEpostaAdresi.Text.Trim());

                    mail.Subject = "Doktorum Randevu Sistemi";
                    mail.IsBodyHtml = true;
                    string mail_html = "<div style='display:block;width:600px; border:1px solid #ccc; margin-left:auto;margin-right:auto; padding:10px; background:#f4f4f4; overflow:hidden; font:12px Arial;'>";
                    mail_html += "<div style='display:block;border:1px solid #ccc; background:white; width:130px; height:118px; float:left;'>";
                    mail_html += "<img src='https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSrkjxjV7EiU09yY7lWBNvPMuAyc4Ej8NmWMVvAh-FA_13onN8G7j8DzpI' alt='Doktorum' width='130' height='118' />";
                    mail_html += "</div>";
                    mail_html += "<div style='width:430px; margin-left:10px; border:1px solid #ccc; padding:5px; float:left; background:white;'>";
                    mail_html += "<center><font color='blue'><h3>DOKTORUM - Randevu Sistemi</h3></font></center>";
                    mail_html += "<br>";
                    mail_html += "Sayın " + lblIsımSoyisim.Text + ",<br><br>";
                    mail_html += "Bu mail bilgilendirme amaçlı olup resmi bir belge yerine geçmez.<br>";
                    mail_html += "<hr size='1'/>";
                    mail_html += "<br>";
                    mail_html += "<u>" + lblRandevuTarihi.Text + "</u> tarihli randevu bilgileriniz aşağıdaki gibi düzenlendi.<br><br>";
                    mail_html += "<b>Hastane</b><br>" + lblHastaneAdi.Text + "<br><br>";
                    mail_html += "<b>Bölüm</b><br>" + lblBolum.Text + "<br><br>";
                    mail_html += "<b>Randevu No :</b><br>" + lblRandevuNo.Text + "<br><br>";
                    mail_html += "<b>Randevu Tarihi</b><br>" + lblRandevuTarihi.Text + "<br><br>";
                    mail_html += "<b>Randevu Saati :</b><br>" + lblRandevuSaat.Text + "<br><br>";
                    mail_html += "<b>Hekim Adı :</b><br>" + lblHekimAdi.Text + "<br><br>";
                    mail_html += "</div>";
                    mail_html += "</div>";
                    mail.Body = mail_html;
                    sc.Send(mail);
                    MessageBox.Show("Randevu Detayları Mail Olarak Gönderildi");
                }
                catch
                {
                    MessageBox.Show("Bir Hata Nedeniyle Mail Gönderilemedi !");
                }
            }
            else
            {
                MessageBox.Show("Randevu Detaylarını Göndermek İstediğiniz Eposta Adresini Giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnHekimDetay_Click(object sender, EventArgs e)
        {
            HekimDetay form = new HekimDetay();
            form.lblHekimID.Text = lblHekimNo.Text;
            form.ShowDialog();
        }

        private void lblHastaneDetay_Click(object sender, EventArgs e)
        {
            HastaneDetay form = new HastaneDetay();
            form.lblHastaneID.Text = lblHastaneNo.Text;
            form.ShowDialog();
        }

        
    }
}
