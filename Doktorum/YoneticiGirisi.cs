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
    public partial class YoneticiGirisi : Form
    {
        private GirisForm giris_formu;
        private AnaForm ana_form;
        public YoneticiGirisi()
        {
            InitializeComponent();
        }
        public YoneticiGirisi(GirisForm form)
        {
            InitializeComponent();
            this.giris_formu = form;
        }
        public YoneticiGirisi(AnaForm form)
        {
            InitializeComponent();
            this.ana_form = form;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClassYoneticiGirisi protokol = new ClassYoneticiGirisi(txtUsername.Text, txtPassword.Text);
            bool durum = protokol.Giris(protokol.username, protokol.password);
            if (durum == true)
            {
                lblSonuc.Text = "Giriş Başarılı";
                GirisForm formgiris = new GirisForm();

                AnaForm git = new AnaForm(this);
                git.Show();

                giris_formu.label2.Text = "Success";
                this.Close();
                
            }
            else
            {
                lblSonuc.Text = "Kullanıcı Adı Veya Parola Hatalı !";
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void YoneticiGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            //giris_formu.label2.Text = "Show";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris_formu.label2.Text = "Show";
            this.Close();
        }
    }
}
