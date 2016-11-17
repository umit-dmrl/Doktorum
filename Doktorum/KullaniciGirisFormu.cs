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
    public partial class KullaniciGirisFormu : Form
    {
        private GirisForm giris_formu;
        public KullaniciGirisFormu()
        {
            InitializeComponent();
        }
        public KullaniciGirisFormu(GirisForm form)
        {
            InitializeComponent();
            this.giris_formu = form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKimlikNo.Text.Length == 11)
            {
                KullaniciRandevuFormu git = new KullaniciRandevuFormu(this);
                git.Show();
                this.Close();
                giris_formu.label2.Text = "Success";
            }
            else
            {
                MessageBox.Show("Eksik sayılar var !\nLütfen 11 haneli kimlik numaranızı giriniz.","Uyarı");
            }
        }

    }
}
