namespace Doktorum
{
    partial class RandevuAl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.grpHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.txtKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.tarih_sec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHastaneSecimi = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHastaneAra = new System.Windows.Forms.Button();
            this.il_sec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHastaneArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHastaneID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHastaneAdi = new System.Windows.Forms.Label();
            this.grpHastaneBilgileri = new System.Windows.Forms.GroupBox();
            this.btnAdimHekimBransSecimi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.combobox_poliklinik = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listHekimler = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpHekimBrans = new System.Windows.Forms.GroupBox();
            this.lblHastaKabulGunleri = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSecilenHekimBrans = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSecilenHekimAdi = new System.Windows.Forms.Label();
            this.lblSecilenHekimID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdimTarihSaat = new System.Windows.Forms.Button();
            this.btnBransFiltrele = new System.Windows.Forms.Button();
            this.grpTarihSaat = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBilgiKontrol = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpHastaneSecimi.SuspendLayout();
            this.grpHastaneBilgileri.SuspendLayout();
            this.grpHekimBrans.SuspendLayout();
            this.grpTarihSaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(123, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(219, 25);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Randevu Kayıt Ekranı";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.White;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Maroon;
            this.lblTarih.Location = new System.Drawing.Point(133, 52);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(19, 13);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "---";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.White;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Maroon;
            this.lblSaat.Location = new System.Drawing.Point(133, 68);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(19, 13);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(985, 690);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Teal;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.FillColor = System.Drawing.Color.White;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(128, 46);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(209, 42);
            // 
            // grpHastaBilgileri
            // 
            this.grpHastaBilgileri.Controls.Add(this.txtKimlikNo);
            this.grpHastaBilgileri.Controls.Add(this.tarih_sec);
            this.grpHastaBilgileri.Controls.Add(this.label3);
            this.grpHastaBilgileri.Controls.Add(this.txtAdSoyad);
            this.grpHastaBilgileri.Controls.Add(this.label2);
            this.grpHastaBilgileri.Controls.Add(this.label1);
            this.grpHastaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHastaBilgileri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpHastaBilgileri.Location = new System.Drawing.Point(12, 113);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(390, 226);
            this.grpHastaBilgileri.TabIndex = 6;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(25, 47);
            this.txtKimlikNo.Mask = "00000000000";
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(84, 22);
            this.txtKimlikNo.TabIndex = 0;
            // 
            // tarih_sec
            // 
            this.tarih_sec.FormattingEnabled = true;
            this.tarih_sec.Location = new System.Drawing.Point(25, 150);
            this.tarih_sec.Name = "tarih_sec";
            this.tarih_sec.Size = new System.Drawing.Size(121, 24);
            this.tarih_sec.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğum Yılı";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(25, 101);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(223, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC. Kimlik Numarası (11 haneli kimlik numaranız)";
            // 
            // grpHastaneSecimi
            // 
            this.grpHastaneSecimi.Controls.Add(this.label6);
            this.grpHastaneSecimi.Controls.Add(this.btnHastaneAra);
            this.grpHastaneSecimi.Controls.Add(this.il_sec);
            this.grpHastaneSecimi.Controls.Add(this.label5);
            this.grpHastaneSecimi.Controls.Add(this.txtHastaneArama);
            this.grpHastaneSecimi.Controls.Add(this.label4);
            this.grpHastaneSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHastaneSecimi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpHastaneSecimi.Location = new System.Drawing.Point(439, 10);
            this.grpHastaneSecimi.Name = "grpHastaneSecimi";
            this.grpHastaneSecimi.Size = new System.Drawing.Size(533, 226);
            this.grpHastaneSecimi.TabIndex = 7;
            this.grpHastaneSecimi.TabStop = false;
            this.grpHastaneSecimi.Text = "Hastane Seçimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(18, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Not : Sadece İl Seçip Hastane Kısmını Boş Bırakıp İllere Göre Arama Yapabilirsini" +
    "z";
            // 
            // btnHastaneAra
            // 
            this.btnHastaneAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHastaneAra.Image = global::Doktorum.Properties.Resources.arama_fw;
            this.btnHastaneAra.Location = new System.Drawing.Point(21, 159);
            this.btnHastaneAra.Name = "btnHastaneAra";
            this.btnHastaneAra.Size = new System.Drawing.Size(116, 43);
            this.btnHastaneAra.TabIndex = 5;
            this.btnHastaneAra.Text = "Hastane Ara";
            this.btnHastaneAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHastaneAra.UseVisualStyleBackColor = true;
            this.btnHastaneAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // il_sec
            // 
            this.il_sec.FormattingEnabled = true;
            this.il_sec.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.il_sec.Location = new System.Drawing.Point(21, 99);
            this.il_sec.Name = "il_sec";
            this.il_sec.Size = new System.Drawing.Size(223, 24);
            this.il_sec.TabIndex = 4;
            this.il_sec.Text = "Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(18, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "İl Seçiniz";
            // 
            // txtHastaneArama
            // 
            this.txtHastaneArama.Location = new System.Drawing.Point(21, 47);
            this.txtHastaneArama.Name = "txtHastaneArama";
            this.txtHastaneArama.Size = new System.Drawing.Size(223, 22);
            this.txtHastaneArama.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hastanenin Tam Adı Veya Belli Bir Bölümünü İçeren Kelime Giriniz";
            // 
            // lblHastaneID
            // 
            this.lblHastaneID.AutoSize = true;
            this.lblHastaneID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHastaneID.Location = new System.Drawing.Point(113, 31);
            this.lblHastaneID.Name = "lblHastaneID";
            this.lblHastaneID.Size = new System.Drawing.Size(20, 16);
            this.lblHastaneID.TabIndex = 3;
            this.lblHastaneID.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hastane No : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(18, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hastane Adı : ";
            // 
            // lblHastaneAdi
            // 
            this.lblHastaneAdi.AutoSize = true;
            this.lblHastaneAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHastaneAdi.Location = new System.Drawing.Point(113, 64);
            this.lblHastaneAdi.Name = "lblHastaneAdi";
            this.lblHastaneAdi.Size = new System.Drawing.Size(20, 16);
            this.lblHastaneAdi.TabIndex = 6;
            this.lblHastaneAdi.Text = "---";
            // 
            // grpHastaneBilgileri
            // 
            this.grpHastaneBilgileri.Controls.Add(this.btnAdimHekimBransSecimi);
            this.grpHastaneBilgileri.Controls.Add(this.lblHastaneAdi);
            this.grpHastaneBilgileri.Controls.Add(this.label8);
            this.grpHastaneBilgileri.Controls.Add(this.label7);
            this.grpHastaneBilgileri.Controls.Add(this.lblHastaneID);
            this.grpHastaneBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHastaneBilgileri.ForeColor = System.Drawing.Color.White;
            this.grpHastaneBilgileri.Location = new System.Drawing.Point(12, 349);
            this.grpHastaneBilgileri.Name = "grpHastaneBilgileri";
            this.grpHastaneBilgileri.Size = new System.Drawing.Size(390, 134);
            this.grpHastaneBilgileri.TabIndex = 8;
            this.grpHastaneBilgileri.TabStop = false;
            this.grpHastaneBilgileri.Text = "Seçim Yaptığınız Hastane Bilgileri";
            // 
            // btnAdimHekimBransSecimi
            // 
            this.btnAdimHekimBransSecimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdimHekimBransSecimi.Image = global::Doktorum.Properties.Resources.orange_next_fw;
            this.btnAdimHekimBransSecimi.Location = new System.Drawing.Point(254, 93);
            this.btnAdimHekimBransSecimi.Name = "btnAdimHekimBransSecimi";
            this.btnAdimHekimBransSecimi.Size = new System.Drawing.Size(130, 35);
            this.btnAdimHekimBransSecimi.TabIndex = 6;
            this.btnAdimHekimBransSecimi.Text = "Sonraki Adım";
            this.btnAdimHekimBransSecimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdimHekimBransSecimi.UseVisualStyleBackColor = true;
            this.btnAdimHekimBransSecimi.Click += new System.EventHandler(this.btnAdimHekimBransSecimi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(18, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Branş Seçiniz : ";
            // 
            // combobox_poliklinik
            // 
            this.combobox_poliklinik.FormattingEnabled = true;
            this.combobox_poliklinik.Location = new System.Drawing.Point(122, 28);
            this.combobox_poliklinik.Name = "combobox_poliklinik";
            this.combobox_poliklinik.Size = new System.Drawing.Size(278, 24);
            this.combobox_poliklinik.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(18, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hekimler :  ";
            // 
            // listHekimler
            // 
            this.listHekimler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1});
            this.listHekimler.FullRowSelect = true;
            this.listHekimler.GridLines = true;
            this.listHekimler.Location = new System.Drawing.Point(21, 95);
            this.listHekimler.MultiSelect = false;
            this.listHekimler.Name = "listHekimler";
            this.listHekimler.Size = new System.Drawing.Size(492, 127);
            this.listHekimler.TabIndex = 9;
            this.listHekimler.UseCompatibleStateImageBehavior = false;
            this.listHekimler.View = System.Windows.Forms.View.Details;
            this.listHekimler.Click += new System.EventHandler(this.listHekimler_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı Soyadı";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Uzmanlık";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hastane";
            this.columnHeader1.Width = 129;
            // 
            // grpHekimBrans
            // 
            this.grpHekimBrans.Controls.Add(this.lblHastaKabulGunleri);
            this.grpHekimBrans.Controls.Add(this.label13);
            this.grpHekimBrans.Controls.Add(this.lblSecilenHekimBrans);
            this.grpHekimBrans.Controls.Add(this.label14);
            this.grpHekimBrans.Controls.Add(this.lblSecilenHekimAdi);
            this.grpHekimBrans.Controls.Add(this.lblSecilenHekimID);
            this.grpHekimBrans.Controls.Add(this.label12);
            this.grpHekimBrans.Controls.Add(this.label11);
            this.grpHekimBrans.Controls.Add(this.btnAdimTarihSaat);
            this.grpHekimBrans.Controls.Add(this.btnBransFiltrele);
            this.grpHekimBrans.Controls.Add(this.listHekimler);
            this.grpHekimBrans.Controls.Add(this.label10);
            this.grpHekimBrans.Controls.Add(this.combobox_poliklinik);
            this.grpHekimBrans.Controls.Add(this.label9);
            this.grpHekimBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHekimBrans.ForeColor = System.Drawing.Color.White;
            this.grpHekimBrans.Location = new System.Drawing.Point(439, 257);
            this.grpHekimBrans.Name = "grpHekimBrans";
            this.grpHekimBrans.Size = new System.Drawing.Size(533, 317);
            this.grpHekimBrans.TabIndex = 9;
            this.grpHekimBrans.TabStop = false;
            this.grpHekimBrans.Text = "Hekim Ve Branş İşlemleri";
            this.grpHekimBrans.Visible = false;
            // 
            // lblHastaKabulGunleri
            // 
            this.lblHastaKabulGunleri.AutoSize = true;
            this.lblHastaKabulGunleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaKabulGunleri.Location = new System.Drawing.Point(119, 300);
            this.lblHastaKabulGunleri.Name = "lblHastaKabulGunleri";
            this.lblHastaKabulGunleri.Size = new System.Drawing.Size(16, 13);
            this.lblHastaKabulGunleri.TabIndex = 19;
            this.lblHastaKabulGunleri.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Hasta Kabul Günleri : ";
            // 
            // lblSecilenHekimBrans
            // 
            this.lblSecilenHekimBrans.AutoSize = true;
            this.lblSecilenHekimBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenHekimBrans.Location = new System.Drawing.Point(119, 278);
            this.lblSecilenHekimBrans.Name = "lblSecilenHekimBrans";
            this.lblSecilenHekimBrans.Size = new System.Drawing.Size(16, 13);
            this.lblSecilenHekimBrans.TabIndex = 17;
            this.lblSecilenHekimBrans.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(73, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Branş : ";
            // 
            // lblSecilenHekimAdi
            // 
            this.lblSecilenHekimAdi.AutoSize = true;
            this.lblSecilenHekimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenHekimAdi.Location = new System.Drawing.Point(119, 251);
            this.lblSecilenHekimAdi.Name = "lblSecilenHekimAdi";
            this.lblSecilenHekimAdi.Size = new System.Drawing.Size(16, 13);
            this.lblSecilenHekimAdi.TabIndex = 15;
            this.lblSecilenHekimAdi.Text = "---";
            // 
            // lblSecilenHekimID
            // 
            this.lblSecilenHekimID.AutoSize = true;
            this.lblSecilenHekimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenHekimID.Location = new System.Drawing.Point(119, 228);
            this.lblSecilenHekimID.Name = "lblSecilenHekimID";
            this.lblSecilenHekimID.Size = new System.Drawing.Size(16, 13);
            this.lblSecilenHekimID.TabIndex = 14;
            this.lblSecilenHekimID.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(52, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Hekim Adı : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(18, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Seçilen Hekim ID : ";
            // 
            // btnAdimTarihSaat
            // 
            this.btnAdimTarihSaat.Enabled = false;
            this.btnAdimTarihSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdimTarihSaat.Image = global::Doktorum.Properties.Resources.orange_next_fw;
            this.btnAdimTarihSaat.Location = new System.Drawing.Point(357, 228);
            this.btnAdimTarihSaat.Name = "btnAdimTarihSaat";
            this.btnAdimTarihSaat.Size = new System.Drawing.Size(156, 35);
            this.btnAdimTarihSaat.TabIndex = 10;
            this.btnAdimTarihSaat.Text = "Tarih Ve Saati Seç";
            this.btnAdimTarihSaat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdimTarihSaat.UseVisualStyleBackColor = true;
            this.btnAdimTarihSaat.Click += new System.EventHandler(this.btnAdimTarihSaat_Click);
            // 
            // btnBransFiltrele
            // 
            this.btnBransFiltrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBransFiltrele.Image = global::Doktorum.Properties.Resources.arama_fw;
            this.btnBransFiltrele.Location = new System.Drawing.Point(406, 25);
            this.btnBransFiltrele.Name = "btnBransFiltrele";
            this.btnBransFiltrele.Size = new System.Drawing.Size(75, 31);
            this.btnBransFiltrele.TabIndex = 8;
            this.btnBransFiltrele.Text = "Ara";
            this.btnBransFiltrele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBransFiltrele.UseVisualStyleBackColor = true;
            this.btnBransFiltrele.Click += new System.EventHandler(this.button3_Click);
            // 
            // grpTarihSaat
            // 
            this.grpTarihSaat.Controls.Add(this.label18);
            this.grpTarihSaat.Controls.Add(this.listBox1);
            this.grpTarihSaat.Controls.Add(this.label15);
            this.grpTarihSaat.Controls.Add(this.btnBilgiKontrol);
            this.grpTarihSaat.Controls.Add(this.dateTimePicker1);
            this.grpTarihSaat.Controls.Add(this.label17);
            this.grpTarihSaat.Controls.Add(this.label16);
            this.grpTarihSaat.Enabled = false;
            this.grpTarihSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpTarihSaat.ForeColor = System.Drawing.Color.White;
            this.grpTarihSaat.Location = new System.Drawing.Point(12, 491);
            this.grpTarihSaat.Name = "grpTarihSaat";
            this.grpTarihSaat.Size = new System.Drawing.Size(390, 195);
            this.grpTarihSaat.TabIndex = 11;
            this.grpTarihSaat.TabStop = false;
            this.grpTarihSaat.Text = "Gün Ve Zaman Seçimi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Hekimin Hasta Kabul Günü Değil";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 85);
            this.listBox1.Margin = new System.Windows.Forms.Padding(20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 100);
            this.listBox1.TabIndex = 21;
            this.listBox1.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(256, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "---";
            // 
            // btnBilgiKontrol
            // 
            this.btnBilgiKontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBilgiKontrol.Image = global::Doktorum.Properties.Resources.orange_next_fw;
            this.btnBilgiKontrol.Location = new System.Drawing.Point(178, 150);
            this.btnBilgiKontrol.Name = "btnBilgiKontrol";
            this.btnBilgiKontrol.Size = new System.Drawing.Size(165, 35);
            this.btnBilgiKontrol.TabIndex = 14;
            this.btnBilgiKontrol.Text = "Bilgileri Kontrol Edin";
            this.btnBilgiKontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBilgiKontrol.UseVisualStyleBackColor = true;
            this.btnBilgiKontrol.Click += new System.EventHandler(this.btnBilgiKontrol_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(256, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Seçilen Tarih";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(256, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 18;
            this.label16.Text = "---";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.Enabled = false;
            this.btnRandevuOlustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRandevuOlustur.Image = global::Doktorum.Properties.Resources.kalp_fw;
            this.btnRandevuOlustur.Location = new System.Drawing.Point(822, 641);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(150, 45);
            this.btnRandevuOlustur.TabIndex = 15;
            this.btnRandevuOlustur.Text = "Randevuyu Tamamla";
            this.btnRandevuOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRandevuOlustur.UseVisualStyleBackColor = true;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Doktorum.Properties.Resources.Head_physician;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(985, 690);
            this.Controls.Add(this.grpTarihSaat);
            this.Controls.Add(this.btnRandevuOlustur);
            this.Controls.Add(this.grpHekimBrans);
            this.Controls.Add(this.grpHastaneBilgileri);
            this.Controls.Add(this.grpHastaneSecimi);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "RandevuAl";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Al";
            this.Load += new System.EventHandler(this.RandevuAl_Load);
            this.grpHastaBilgileri.ResumeLayout(false);
            this.grpHastaBilgileri.PerformLayout();
            this.grpHastaneSecimi.ResumeLayout(false);
            this.grpHastaneSecimi.PerformLayout();
            this.grpHastaneBilgileri.ResumeLayout(false);
            this.grpHastaneBilgileri.PerformLayout();
            this.grpHekimBrans.ResumeLayout(false);
            this.grpHekimBrans.PerformLayout();
            this.grpTarihSaat.ResumeLayout(false);
            this.grpTarihSaat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.GroupBox grpHastaBilgileri;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tarih_sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpHastaneSecimi;
        private System.Windows.Forms.TextBox txtHastaneArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox il_sec;
        private System.Windows.Forms.Button btnHastaneAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRandevuOlustur;
        public System.Windows.Forms.Label lblHastaneID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblHastaneAdi;
        private System.Windows.Forms.Button btnAdimHekimBransSecimi;
        private System.Windows.Forms.GroupBox grpHastaneBilgileri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combobox_poliklinik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listHekimler;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnBransFiltrele;
        private System.Windows.Forms.GroupBox grpHekimBrans;
        private System.Windows.Forms.GroupBox grpTarihSaat;
        private System.Windows.Forms.Button btnAdimTarihSaat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSecilenHekimAdi;
        private System.Windows.Forms.Label lblSecilenHekimID;
        private System.Windows.Forms.Button btnBilgiKontrol;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MaskedTextBox txtKimlikNo;
        private System.Windows.Forms.Label lblSecilenHekimBrans;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblHastaKabulGunleri;
        private System.Windows.Forms.Label label18;
    }
}