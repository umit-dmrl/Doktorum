using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doktorum
{
    public partial class HastaneDetay : Form
    {
        public HastaneDetay()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            string[] sutunlar = { "hastaneAdi", "hastaneTuru", "hastaneTel", "hastaneFax", "hastane_il", "hastaneAdres", "hastaneEmail", "hastaneWeb", "hastaneGoogleMaps" };
            string gelenVeriler = vt.veri_cek("Hastaneler",sutunlar,"id="+lblHastaneID.Text);
            string[] degerler = gelenVeriler.Split('$');
            lblHastaneAdi.Text = degerler[0].ToString();
            lblHastaneTuru.Text = degerler[1].ToString();
            lblTel.Text = degerler[2];
            lblFax.Text = degerler[3];
            lblIl.Text = degerler[4];
            richTextBox1.Text = degerler[5];
            lblEposta.Text = degerler[6];
            lblWeb.Text = degerler[7];
            string html_file_name = degerler[8];
            webBrowser1.ScriptErrorsSuppressed = true;
            string curDir = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/maps/" + html_file_name + ".html", curDir));
        }
    }
}
