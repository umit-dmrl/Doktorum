namespace Doktorum
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hekimMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hekimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hekimListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışmaSaatleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaneMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaneKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaneListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.poliklinikAtamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OtomasyonHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GelistiricilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ProgramiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = global::Doktorum.Properties.Resources.sidebar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hekimMenüsüToolStripMenuItem,
            this.hastaneMenüsüToolStripMenuItem,
            this.randevuMenüsüToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hekimMenüsüToolStripMenuItem
            // 
            this.hekimMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hekimEkleToolStripMenuItem,
            this.hekimListesiToolStripMenuItem,
            this.çalışmaSaatleriToolStripMenuItem});
            this.hekimMenüsüToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hekimMenüsüToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hekimMenüsüToolStripMenuItem.Image = global::Doktorum.Properties.Resources.Head_physician;
            this.hekimMenüsüToolStripMenuItem.Name = "hekimMenüsüToolStripMenuItem";
            this.hekimMenüsüToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.hekimMenüsüToolStripMenuItem.Text = "Hekim Menüsü";
            // 
            // hekimEkleToolStripMenuItem
            // 
            this.hekimEkleToolStripMenuItem.Name = "hekimEkleToolStripMenuItem";
            this.hekimEkleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hekimEkleToolStripMenuItem.Text = "Hekim Kaydı";
            this.hekimEkleToolStripMenuItem.Click += new System.EventHandler(this.hekimEkleToolStripMenuItem_Click);
            // 
            // hekimListesiToolStripMenuItem
            // 
            this.hekimListesiToolStripMenuItem.Name = "hekimListesiToolStripMenuItem";
            this.hekimListesiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hekimListesiToolStripMenuItem.Text = "Hekim Listesi";
            this.hekimListesiToolStripMenuItem.Click += new System.EventHandler(this.hekimListesiToolStripMenuItem_Click);
            // 
            // çalışmaSaatleriToolStripMenuItem
            // 
            this.çalışmaSaatleriToolStripMenuItem.Name = "çalışmaSaatleriToolStripMenuItem";
            this.çalışmaSaatleriToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.çalışmaSaatleriToolStripMenuItem.Text = "Çalışma Günleri";
            this.çalışmaSaatleriToolStripMenuItem.Click += new System.EventHandler(this.çalışmaSaatleriToolStripMenuItem_Click);
            // 
            // hastaneMenüsüToolStripMenuItem
            // 
            this.hastaneMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaneKaydıToolStripMenuItem,
            this.hastaneListesiToolStripMenuItem,
            this.toolStripSeparator1,
            this.poliklinikAtamaToolStripMenuItem});
            this.hastaneMenüsüToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaneMenüsüToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hastaneMenüsüToolStripMenuItem.Image = global::Doktorum.Properties.Resources.kalp_fw;
            this.hastaneMenüsüToolStripMenuItem.Name = "hastaneMenüsüToolStripMenuItem";
            this.hastaneMenüsüToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.hastaneMenüsüToolStripMenuItem.Text = "Hastane Menüsü";
            // 
            // hastaneKaydıToolStripMenuItem
            // 
            this.hastaneKaydıToolStripMenuItem.Name = "hastaneKaydıToolStripMenuItem";
            this.hastaneKaydıToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hastaneKaydıToolStripMenuItem.Text = "Hastane Kaydı";
            this.hastaneKaydıToolStripMenuItem.Click += new System.EventHandler(this.hastaneKaydıToolStripMenuItem_Click);
            // 
            // hastaneListesiToolStripMenuItem
            // 
            this.hastaneListesiToolStripMenuItem.Name = "hastaneListesiToolStripMenuItem";
            this.hastaneListesiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hastaneListesiToolStripMenuItem.Text = "Hastane Listesi";
            this.hastaneListesiToolStripMenuItem.Click += new System.EventHandler(this.hastaneListesiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // poliklinikAtamaToolStripMenuItem
            // 
            this.poliklinikAtamaToolStripMenuItem.Name = "poliklinikAtamaToolStripMenuItem";
            this.poliklinikAtamaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.poliklinikAtamaToolStripMenuItem.Text = "Poliklinik Atama";
            this.poliklinikAtamaToolStripMenuItem.Click += new System.EventHandler(this.poliklinikAtamaToolStripMenuItem_Click);
            // 
            // randevuMenüsüToolStripMenuItem
            // 
            this.randevuMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.randevuSorgulaToolStripMenuItem});
            this.randevuMenüsüToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuMenüsüToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.randevuMenüsüToolStripMenuItem.Image = global::Doktorum.Properties.Resources.zaman;
            this.randevuMenüsüToolStripMenuItem.Name = "randevuMenüsüToolStripMenuItem";
            this.randevuMenüsüToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.randevuMenüsüToolStripMenuItem.Text = "Randevu Menüsü";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // randevuSorgulaToolStripMenuItem
            // 
            this.randevuSorgulaToolStripMenuItem.Name = "randevuSorgulaToolStripMenuItem";
            this.randevuSorgulaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.randevuSorgulaToolStripMenuItem.Text = "Randevu Sorgula";
            this.randevuSorgulaToolStripMenuItem.Click += new System.EventHandler(this.randevuSorgulaToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışYapToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OtomasyonHakkindaToolStripMenuItem,
            this.toolStripSeparator2,
            this.GelistiricilerToolStripMenuItem,
            this.toolStripSeparator3,
            this.ProgramiKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 82);
            // 
            // OtomasyonHakkindaToolStripMenuItem
            // 
            this.OtomasyonHakkindaToolStripMenuItem.Name = "OtomasyonHakkindaToolStripMenuItem";
            this.OtomasyonHakkindaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.OtomasyonHakkindaToolStripMenuItem.Text = "Otomasyon Hakkında";
            this.OtomasyonHakkindaToolStripMenuItem.Click += new System.EventHandler(this.OtomasyonHakkindaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // GelistiricilerToolStripMenuItem
            // 
            this.GelistiricilerToolStripMenuItem.Name = "GelistiricilerToolStripMenuItem";
            this.GelistiricilerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.GelistiricilerToolStripMenuItem.Text = "Geliştiriciler";
            this.GelistiricilerToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // ProgramiKapatToolStripMenuItem
            // 
            this.ProgramiKapatToolStripMenuItem.Name = "ProgramiKapatToolStripMenuItem";
            this.ProgramiKapatToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ProgramiKapatToolStripMenuItem.Text = "Programı Kapat";
            this.ProgramiKapatToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 522);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doktorum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaForm_FormClosed);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hekimMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaneMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hekimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hekimListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışmaSaatleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaneKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaneListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikAtamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OtomasyonHakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GelistiricilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramiKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem randevuSorgulaToolStripMenuItem;
    }
}

