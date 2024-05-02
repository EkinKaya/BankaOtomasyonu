namespace BankaOtomasyonu
{
    partial class BankaGirisiFormu
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
            this.tbCntrlBankaGirisi = new System.Windows.Forms.TabControl();
            this.tbPgPersonelEkle = new System.Windows.Forms.TabPage();
            this.btnAnasayfayaDon1 = new System.Windows.Forms.Button();
            this.grpBxPersonelBilgiGirisi = new System.Windows.Forms.GroupBox();
            this.txtbxPersonelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtbxPersonelSifre = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtbxPersonelSoyad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtbxPersonelAd = new System.Windows.Forms.TextBox();
            this.tbPgPersonelSil = new System.Windows.Forms.TabPage();
            this.btnAnasayfayaDon2 = new System.Windows.Forms.Button();
            this.grpBxPersonelSil = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblPersonelSilAdi = new System.Windows.Forms.Label();
            this.txtbxPersonelSilAdi = new System.Windows.Forms.TextBox();
            this.tbPgPersonelListele = new System.Windows.Forms.TabPage();
            this.btnAnasayfayaDon3 = new System.Windows.Forms.Button();
            this.dtGridViwPersonelListele = new System.Windows.Forms.DataGridView();
            this.tbPgGelirGiderRaporu = new System.Windows.Forms.TabPage();
            this.btnAnasayfayaDon4 = new System.Windows.Forms.Button();
            this.btnRaporuListele = new System.Windows.Forms.Button();
            this.lblBankaHazinesi = new System.Windows.Forms.Label();
            this.dtGridViwGelirGiderRaporu = new System.Windows.Forms.DataGridView();
            this.tbCntrlBankaGirisi.SuspendLayout();
            this.tbPgPersonelEkle.SuspendLayout();
            this.grpBxPersonelBilgiGirisi.SuspendLayout();
            this.tbPgPersonelSil.SuspendLayout();
            this.grpBxPersonelSil.SuspendLayout();
            this.tbPgPersonelListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViwPersonelListele)).BeginInit();
            this.tbPgGelirGiderRaporu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViwGelirGiderRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlBankaGirisi
            // 
            this.tbCntrlBankaGirisi.Controls.Add(this.tbPgPersonelEkle);
            this.tbCntrlBankaGirisi.Controls.Add(this.tbPgPersonelSil);
            this.tbCntrlBankaGirisi.Controls.Add(this.tbPgPersonelListele);
            this.tbCntrlBankaGirisi.Controls.Add(this.tbPgGelirGiderRaporu);
            this.tbCntrlBankaGirisi.Location = new System.Drawing.Point(12, 10);
            this.tbCntrlBankaGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCntrlBankaGirisi.Name = "tbCntrlBankaGirisi";
            this.tbCntrlBankaGirisi.SelectedIndex = 0;
            this.tbCntrlBankaGirisi.Size = new System.Drawing.Size(690, 341);
            this.tbCntrlBankaGirisi.TabIndex = 0;
            // 
            // tbPgPersonelEkle
            // 
            this.tbPgPersonelEkle.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgPersonelEkle.Controls.Add(this.btnAnasayfayaDon1);
            this.tbPgPersonelEkle.Controls.Add(this.grpBxPersonelBilgiGirisi);
            this.tbPgPersonelEkle.Location = new System.Drawing.Point(4, 25);
            this.tbPgPersonelEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgPersonelEkle.Name = "tbPgPersonelEkle";
            this.tbPgPersonelEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgPersonelEkle.Size = new System.Drawing.Size(682, 312);
            this.tbPgPersonelEkle.TabIndex = 0;
            this.tbPgPersonelEkle.Text = "Personel Ekle";
            // 
            // btnAnasayfayaDon1
            // 
            this.btnAnasayfayaDon1.Location = new System.Drawing.Point(14, 18);
            this.btnAnasayfayaDon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnasayfayaDon1.Name = "btnAnasayfayaDon1";
            this.btnAnasayfayaDon1.Size = new System.Drawing.Size(99, 62);
            this.btnAnasayfayaDon1.TabIndex = 10;
            this.btnAnasayfayaDon1.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon1.UseVisualStyleBackColor = true;
            this.btnAnasayfayaDon1.Click += new System.EventHandler(this.btnAnasayfayaDon1_Click);
            // 
            // grpBxPersonelBilgiGirisi
            // 
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.txtbxPersonelKullaniciAdi);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.btnPersonelEkle);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.lblAd);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.txtbxPersonelSifre);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.lblSoyad);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.lblKullaniciAdi);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.txtbxPersonelSoyad);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.lblSifre);
            this.grpBxPersonelBilgiGirisi.Controls.Add(this.txtbxPersonelAd);
            this.grpBxPersonelBilgiGirisi.Location = new System.Drawing.Point(133, 39);
            this.grpBxPersonelBilgiGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxPersonelBilgiGirisi.Name = "grpBxPersonelBilgiGirisi";
            this.grpBxPersonelBilgiGirisi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxPersonelBilgiGirisi.Size = new System.Drawing.Size(419, 256);
            this.grpBxPersonelBilgiGirisi.TabIndex = 9;
            this.grpBxPersonelBilgiGirisi.TabStop = false;
            this.grpBxPersonelBilgiGirisi.Text = "Personel Bilgi Girişi";
            // 
            // txtbxPersonelKullaniciAdi
            // 
            this.txtbxPersonelKullaniciAdi.Location = new System.Drawing.Point(139, 115);
            this.txtbxPersonelKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxPersonelKullaniciAdi.Name = "txtbxPersonelKullaniciAdi";
            this.txtbxPersonelKullaniciAdi.Size = new System.Drawing.Size(122, 22);
            this.txtbxPersonelKullaniciAdi.TabIndex = 6;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(162, 205);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(99, 30);
            this.btnPersonelEkle.TabIndex = 8;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(36, 49);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // txtbxPersonelSifre
            // 
            this.txtbxPersonelSifre.Location = new System.Drawing.Point(139, 153);
            this.txtbxPersonelSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxPersonelSifre.Name = "txtbxPersonelSifre";
            this.txtbxPersonelSifre.PasswordChar = '*';
            this.txtbxPersonelSifre.Size = new System.Drawing.Size(122, 22);
            this.txtbxPersonelSifre.TabIndex = 7;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(36, 82);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 17);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(36, 115);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(88, 17);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtbxPersonelSoyad
            // 
            this.txtbxPersonelSoyad.Location = new System.Drawing.Point(139, 82);
            this.txtbxPersonelSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxPersonelSoyad.Name = "txtbxPersonelSoyad";
            this.txtbxPersonelSoyad.Size = new System.Drawing.Size(122, 22);
            this.txtbxPersonelSoyad.TabIndex = 5;
            this.txtbxPersonelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPersonelSoyad_KeyPress);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(36, 153);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 17);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Sifre:";
            // 
            // txtbxPersonelAd
            // 
            this.txtbxPersonelAd.Location = new System.Drawing.Point(139, 49);
            this.txtbxPersonelAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxPersonelAd.Name = "txtbxPersonelAd";
            this.txtbxPersonelAd.Size = new System.Drawing.Size(122, 22);
            this.txtbxPersonelAd.TabIndex = 4;
            this.txtbxPersonelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPersonelAd_KeyPress);
            // 
            // tbPgPersonelSil
            // 
            this.tbPgPersonelSil.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgPersonelSil.Controls.Add(this.btnAnasayfayaDon2);
            this.tbPgPersonelSil.Controls.Add(this.grpBxPersonelSil);
            this.tbPgPersonelSil.Location = new System.Drawing.Point(4, 25);
            this.tbPgPersonelSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgPersonelSil.Name = "tbPgPersonelSil";
            this.tbPgPersonelSil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgPersonelSil.Size = new System.Drawing.Size(682, 312);
            this.tbPgPersonelSil.TabIndex = 1;
            this.tbPgPersonelSil.Text = "Personel Sil";
            // 
            // btnAnasayfayaDon2
            // 
            this.btnAnasayfayaDon2.Location = new System.Drawing.Point(14, 14);
            this.btnAnasayfayaDon2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnasayfayaDon2.Name = "btnAnasayfayaDon2";
            this.btnAnasayfayaDon2.Size = new System.Drawing.Size(99, 59);
            this.btnAnasayfayaDon2.TabIndex = 11;
            this.btnAnasayfayaDon2.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon2.UseVisualStyleBackColor = true;
            this.btnAnasayfayaDon2.Click += new System.EventHandler(this.btnAnasayfayaDon2_Click);
            // 
            // grpBxPersonelSil
            // 
            this.grpBxPersonelSil.Controls.Add(this.btnSil);
            this.grpBxPersonelSil.Controls.Add(this.lblPersonelSilAdi);
            this.grpBxPersonelSil.Controls.Add(this.txtbxPersonelSilAdi);
            this.grpBxPersonelSil.Location = new System.Drawing.Point(162, 70);
            this.grpBxPersonelSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxPersonelSil.Name = "grpBxPersonelSil";
            this.grpBxPersonelSil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxPersonelSil.Size = new System.Drawing.Size(419, 168);
            this.grpBxPersonelSil.TabIndex = 10;
            this.grpBxPersonelSil.TabStop = false;
            this.grpBxPersonelSil.Text = "Personel Bilgi Girişi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(162, 96);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 30);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblPersonelSilAdi
            // 
            this.lblPersonelSilAdi.AutoSize = true;
            this.lblPersonelSilAdi.Location = new System.Drawing.Point(36, 54);
            this.lblPersonelSilAdi.Name = "lblPersonelSilAdi";
            this.lblPersonelSilAdi.Size = new System.Drawing.Size(92, 17);
            this.lblPersonelSilAdi.TabIndex = 0;
            this.lblPersonelSilAdi.Text = "Personel Adi:";
            // 
            // txtbxPersonelSilAdi
            // 
            this.txtbxPersonelSilAdi.Location = new System.Drawing.Point(139, 54);
            this.txtbxPersonelSilAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxPersonelSilAdi.Name = "txtbxPersonelSilAdi";
            this.txtbxPersonelSilAdi.Size = new System.Drawing.Size(122, 22);
            this.txtbxPersonelSilAdi.TabIndex = 4;
            // 
            // tbPgPersonelListele
            // 
            this.tbPgPersonelListele.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgPersonelListele.Controls.Add(this.btnAnasayfayaDon3);
            this.tbPgPersonelListele.Controls.Add(this.dtGridViwPersonelListele);
            this.tbPgPersonelListele.Location = new System.Drawing.Point(4, 25);
            this.tbPgPersonelListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgPersonelListele.Name = "tbPgPersonelListele";
            this.tbPgPersonelListele.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgPersonelListele.Size = new System.Drawing.Size(682, 312);
            this.tbPgPersonelListele.TabIndex = 2;
            this.tbPgPersonelListele.Text = "Personel Listele";
            this.tbPgPersonelListele.Click += new System.EventHandler(this.tbPgPersonelListele_Click);
            // 
            // btnAnasayfayaDon3
            // 
            this.btnAnasayfayaDon3.Location = new System.Drawing.Point(5, 5);
            this.btnAnasayfayaDon3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnasayfayaDon3.Name = "btnAnasayfayaDon3";
            this.btnAnasayfayaDon3.Size = new System.Drawing.Size(145, 41);
            this.btnAnasayfayaDon3.TabIndex = 11;
            this.btnAnasayfayaDon3.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon3.UseVisualStyleBackColor = true;
            this.btnAnasayfayaDon3.Click += new System.EventHandler(this.btnAnasayfayaDon3_Click);
            // 
            // dtGridViwPersonelListele
            // 
            this.dtGridViwPersonelListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViwPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViwPersonelListele.Location = new System.Drawing.Point(59, 50);
            this.dtGridViwPersonelListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGridViwPersonelListele.Name = "dtGridViwPersonelListele";
            this.dtGridViwPersonelListele.RowHeadersWidth = 62;
            this.dtGridViwPersonelListele.RowTemplate.Height = 28;
            this.dtGridViwPersonelListele.Size = new System.Drawing.Size(519, 227);
            this.dtGridViwPersonelListele.TabIndex = 0;
            this.dtGridViwPersonelListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViwPersonelListele_CellContentClick);
            // 
            // tbPgGelirGiderRaporu
            // 
            this.tbPgGelirGiderRaporu.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgGelirGiderRaporu.Controls.Add(this.btnAnasayfayaDon4);
            this.tbPgGelirGiderRaporu.Controls.Add(this.btnRaporuListele);
            this.tbPgGelirGiderRaporu.Controls.Add(this.lblBankaHazinesi);
            this.tbPgGelirGiderRaporu.Controls.Add(this.dtGridViwGelirGiderRaporu);
            this.tbPgGelirGiderRaporu.Location = new System.Drawing.Point(4, 25);
            this.tbPgGelirGiderRaporu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgGelirGiderRaporu.Name = "tbPgGelirGiderRaporu";
            this.tbPgGelirGiderRaporu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgGelirGiderRaporu.Size = new System.Drawing.Size(682, 312);
            this.tbPgGelirGiderRaporu.TabIndex = 3;
            this.tbPgGelirGiderRaporu.Text = "Gelir-Gider Raporu";
            // 
            // btnAnasayfayaDon4
            // 
            this.btnAnasayfayaDon4.Location = new System.Drawing.Point(413, 14);
            this.btnAnasayfayaDon4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnasayfayaDon4.Name = "btnAnasayfayaDon4";
            this.btnAnasayfayaDon4.Size = new System.Drawing.Size(143, 38);
            this.btnAnasayfayaDon4.TabIndex = 11;
            this.btnAnasayfayaDon4.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon4.UseVisualStyleBackColor = true;
            this.btnAnasayfayaDon4.Click += new System.EventHandler(this.btnAnasayfayaDon4_Click);
            // 
            // btnRaporuListele
            // 
            this.btnRaporuListele.Location = new System.Drawing.Point(262, 13);
            this.btnRaporuListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaporuListele.Name = "btnRaporuListele";
            this.btnRaporuListele.Size = new System.Drawing.Size(145, 38);
            this.btnRaporuListele.TabIndex = 3;
            this.btnRaporuListele.Text = "Raporu Listele";
            this.btnRaporuListele.UseVisualStyleBackColor = true;
            this.btnRaporuListele.Click += new System.EventHandler(this.btnRaporuListele_Click);
            // 
            // lblBankaHazinesi
            // 
            this.lblBankaHazinesi.AutoSize = true;
            this.lblBankaHazinesi.Location = new System.Drawing.Point(17, 23);
            this.lblBankaHazinesi.Name = "lblBankaHazinesi";
            this.lblBankaHazinesi.Size = new System.Drawing.Size(140, 17);
            this.lblBankaHazinesi.TabIndex = 2;
            this.lblBankaHazinesi.Text = "Banka Hazinesi: - TL";
            // 
            // dtGridViwGelirGiderRaporu
            // 
            this.dtGridViwGelirGiderRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViwGelirGiderRaporu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGridViwGelirGiderRaporu.Location = new System.Drawing.Point(3, 56);
            this.dtGridViwGelirGiderRaporu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGridViwGelirGiderRaporu.Name = "dtGridViwGelirGiderRaporu";
            this.dtGridViwGelirGiderRaporu.RowHeadersWidth = 62;
            this.dtGridViwGelirGiderRaporu.RowTemplate.Height = 28;
            this.dtGridViwGelirGiderRaporu.Size = new System.Drawing.Size(676, 254);
            this.dtGridViwGelirGiderRaporu.TabIndex = 1;
            // 
            // BankaGirisiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.tbCntrlBankaGirisi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BankaGirisiFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Banka Girişi Ekranı";
            this.Load += new System.EventHandler(this.BankaGirisiFormu_Load);
            this.tbCntrlBankaGirisi.ResumeLayout(false);
            this.tbPgPersonelEkle.ResumeLayout(false);
            this.grpBxPersonelBilgiGirisi.ResumeLayout(false);
            this.grpBxPersonelBilgiGirisi.PerformLayout();
            this.tbPgPersonelSil.ResumeLayout(false);
            this.grpBxPersonelSil.ResumeLayout(false);
            this.grpBxPersonelSil.PerformLayout();
            this.tbPgPersonelListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViwPersonelListele)).EndInit();
            this.tbPgGelirGiderRaporu.ResumeLayout(false);
            this.tbPgGelirGiderRaporu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViwGelirGiderRaporu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlBankaGirisi;
        private System.Windows.Forms.TabPage tbPgPersonelEkle;
        private System.Windows.Forms.TabPage tbPgPersonelSil;
        private System.Windows.Forms.TabPage tbPgPersonelListele;
        private System.Windows.Forms.TabPage tbPgGelirGiderRaporu;
        private System.Windows.Forms.GroupBox grpBxPersonelBilgiGirisi;
        private System.Windows.Forms.TextBox txtbxPersonelKullaniciAdi;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtbxPersonelSifre;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtbxPersonelSoyad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtbxPersonelAd;
        private System.Windows.Forms.GroupBox grpBxPersonelSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblPersonelSilAdi;
        private System.Windows.Forms.TextBox txtbxPersonelSilAdi;
        private System.Windows.Forms.DataGridView dtGridViwPersonelListele;
        private System.Windows.Forms.DataGridView dtGridViwGelirGiderRaporu;
        private System.Windows.Forms.Label lblBankaHazinesi;
        private System.Windows.Forms.Button btnRaporuListele;
        private System.Windows.Forms.Button btnAnasayfayaDon1;
        private System.Windows.Forms.Button btnAnasayfayaDon2;
        private System.Windows.Forms.Button btnAnasayfayaDon3;
        private System.Windows.Forms.Button btnAnasayfayaDon4;
    }
}