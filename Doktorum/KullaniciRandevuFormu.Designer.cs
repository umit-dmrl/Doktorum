namespace Doktorum
{
    partial class KullaniciRandevuFormu
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.richTextBox1.BackColor = System.Drawing.Color.Teal;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox1.Location = new System.Drawing.Point(19, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(348, 67);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Randevu ekranına hoşgeldiniz ,\nBu ekrandan tüm randevu işlemlerinizi kolay ve hız" +
    "lı bir şekilde tamamlayabilirsiniz.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRandevuAra);
            this.panel1.Controls.Add(this.btnRandevuAl);
            this.panel1.Location = new System.Drawing.Point(2, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 230);
            this.panel1.TabIndex = 12;
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCikis.Image = global::Doktorum.Properties.Resources.cikis;
            this.btnCikis.Location = new System.Drawing.Point(228, 118);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(142, 51);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "Çıkıp Yap";
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Randevu Yönetim Ekranı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Doktorum.Properties.Resources.Head_physician;
            this.pictureBox1.Location = new System.Drawing.Point(22, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRandevuAra.Image = global::Doktorum.Properties.Resources.arama_fw;
            this.btnRandevuAra.Location = new System.Drawing.Point(228, 61);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(142, 51);
            this.btnRandevuAra.TabIndex = 11;
            this.btnRandevuAra.Text = "Randevu Arama";
            this.btnRandevuAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRandevuAra.UseVisualStyleBackColor = true;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRandevuAl.Image = global::Doktorum.Properties.Resources.zaman;
            this.btnRandevuAl.Location = new System.Drawing.Point(228, 4);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(142, 51);
            this.btnRandevuAl.TabIndex = 10;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // KullaniciRandevuFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(379, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KullaniciRandevuFormu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciRandevuFormu_FormClosed);
            this.Load += new System.EventHandler(this.KullaniciRandevuFormu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.Button btnRandevuAl;
    }
}