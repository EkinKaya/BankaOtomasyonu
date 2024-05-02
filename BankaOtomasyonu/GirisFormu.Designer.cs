namespace BankaOtomasyonu
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.lblKullaniciAdiMusteriNo = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtbxKullaniciAdiMusteriNo = new System.Windows.Forms.TextBox();
            this.txtbxSifre = new System.Windows.Forms.TextBox();
            this.grpBxGirisEkrani = new System.Windows.Forms.GroupBox();
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.grpBxGirisSecenek = new System.Windows.Forms.GroupBox();
            this.btnBankaYoneticisi = new System.Windows.Forms.Button();
            this.btnPersonelGirisi = new System.Windows.Forms.Button();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indirimiYakalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBxGirisEkrani.SuspendLayout();
            this.grpBxGirisSecenek.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdiMusteriNo
            // 
            this.lblKullaniciAdiMusteriNo.AutoSize = true;
            this.lblKullaniciAdiMusteriNo.Location = new System.Drawing.Point(26, 58);
            this.lblKullaniciAdiMusteriNo.Name = "lblKullaniciAdiMusteriNo";
            this.lblKullaniciAdiMusteriNo.Size = new System.Drawing.Size(224, 20);
            this.lblKullaniciAdiMusteriNo.TabIndex = 0;
            this.lblKullaniciAdiMusteriNo.Text = "Kullanıcı Adı/Musteri Numarasi:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(26, 100);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 20);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtbxKullaniciAdiMusteriNo
            // 
            this.txtbxKullaniciAdiMusteriNo.Location = new System.Drawing.Point(279, 58);
            this.txtbxKullaniciAdiMusteriNo.Name = "txtbxKullaniciAdiMusteriNo";
            this.txtbxKullaniciAdiMusteriNo.Size = new System.Drawing.Size(142, 26);
            this.txtbxKullaniciAdiMusteriNo.TabIndex = 2;
            // 
            // txtbxSifre
            // 
            this.txtbxSifre.Location = new System.Drawing.Point(279, 100);
            this.txtbxSifre.Name = "txtbxSifre";
            this.txtbxSifre.PasswordChar = '*';
            this.txtbxSifre.Size = new System.Drawing.Size(142, 26);
            this.txtbxSifre.TabIndex = 3;
            // 
            // grpBxGirisEkrani
            // 
            this.grpBxGirisEkrani.Controls.Add(this.lblKullaniciAdiMusteriNo);
            this.grpBxGirisEkrani.Controls.Add(this.txtbxSifre);
            this.grpBxGirisEkrani.Controls.Add(this.lblSifre);
            this.grpBxGirisEkrani.Controls.Add(this.txtbxKullaniciAdiMusteriNo);
            this.grpBxGirisEkrani.Location = new System.Drawing.Point(225, 145);
            this.grpBxGirisEkrani.Name = "grpBxGirisEkrani";
            this.grpBxGirisEkrani.Size = new System.Drawing.Size(436, 187);
            this.grpBxGirisEkrani.TabIndex = 4;
            this.grpBxGirisEkrani.TabStop = false;
            this.grpBxGirisEkrani.Text = "Giriş Ekranı";
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.Location = new System.Drawing.Point(20, 47);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(115, 47);
            this.btnMusteriGirisi.TabIndex = 5;
            this.btnMusteriGirisi.Text = "Müşteriyim";
            this.btnMusteriGirisi.UseVisualStyleBackColor = true;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // grpBxGirisSecenek
            // 
            this.grpBxGirisSecenek.Controls.Add(this.btnBankaYoneticisi);
            this.grpBxGirisSecenek.Controls.Add(this.btnPersonelGirisi);
            this.grpBxGirisSecenek.Controls.Add(this.btnMusteriGirisi);
            this.grpBxGirisSecenek.Location = new System.Drawing.Point(192, 364);
            this.grpBxGirisSecenek.Name = "grpBxGirisSecenek";
            this.grpBxGirisSecenek.Size = new System.Drawing.Size(551, 100);
            this.grpBxGirisSecenek.TabIndex = 8;
            this.grpBxGirisSecenek.TabStop = false;
            this.grpBxGirisSecenek.Text = "Giriş Seçenekleri";
            // 
            // btnBankaYoneticisi
            // 
            this.btnBankaYoneticisi.Location = new System.Drawing.Point(406, 47);
            this.btnBankaYoneticisi.Name = "btnBankaYoneticisi";
            this.btnBankaYoneticisi.Size = new System.Drawing.Size(115, 47);
            this.btnBankaYoneticisi.TabIndex = 7;
            this.btnBankaYoneticisi.Text = "Banka Girişi";
            this.btnBankaYoneticisi.UseVisualStyleBackColor = true;
            this.btnBankaYoneticisi.Click += new System.EventHandler(this.btnBankaYoneticisi_Click);
            // 
            // btnPersonelGirisi
            // 
            this.btnPersonelGirisi.Location = new System.Drawing.Point(205, 47);
            this.btnPersonelGirisi.Name = "btnPersonelGirisi";
            this.btnPersonelGirisi.Size = new System.Drawing.Size(143, 47);
            this.btnPersonelGirisi.TabIndex = 6;
            this.btnPersonelGirisi.Text = "Personel Girişi";
            this.btnPersonelGirisi.UseVisualStyleBackColor = true;
            this.btnPersonelGirisi.Click += new System.EventHandler(this.btnPersonelGirisi_Click);
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Harlow Solid Italic", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHosgeldiniz.Location = new System.Drawing.Point(33, 55);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(342, 84);
            this.lblHosgeldiniz.TabIndex = 9;
            this.lblHosgeldiniz.Text = "PinkBank ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.indirimiYakalaToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.girişToolStripMenuItem.Text = "Giriş ";
            // 
            // indirimiYakalaToolStripMenuItem
            // 
            this.indirimiYakalaToolStripMenuItem.Name = "indirimiYakalaToolStripMenuItem";
            this.indirimiYakalaToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.indirimiYakalaToolStripMenuItem.Text = "İndirimi Yakala";
            this.indirimiYakalaToolStripMenuItem.Click += new System.EventHandler(this.indirimiYakalaToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(921, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.grpBxGirisSecenek);
            this.Controls.Add(this.grpBxGirisEkrani);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GirisFormu";
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            this.grpBxGirisEkrani.ResumeLayout(false);
            this.grpBxGirisEkrani.PerformLayout();
            this.grpBxGirisSecenek.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdiMusteriNo;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtbxKullaniciAdiMusteriNo;
        private System.Windows.Forms.TextBox txtbxSifre;
        private System.Windows.Forms.GroupBox grpBxGirisEkrani;
        private System.Windows.Forms.Button btnMusteriGirisi;
        private System.Windows.Forms.GroupBox grpBxGirisSecenek;
        private System.Windows.Forms.Button btnBankaYoneticisi;
        private System.Windows.Forms.Button btnPersonelGirisi;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indirimiYakalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}