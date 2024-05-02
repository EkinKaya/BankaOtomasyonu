namespace BankaOtomasyonu
{
    partial class MusteriFormu
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
            this.tbCntrlMusteriFormu = new System.Windows.Forms.TabControl();
            this.tbPgParaCekme = new System.Windows.Forms.TabPage();
            this.grpBxParaCek = new System.Windows.Forms.GroupBox();
            this.lblBakiyeSonuc = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblHesapNumarasi = new System.Windows.Forms.Label();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtbxParaCekmekMiktari = new System.Windows.Forms.TextBox();
            this.txtbxParaCekmeHesapNumarasi = new System.Windows.Forms.TextBox();
            this.tbPgParaYatırma = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHesapNumarasiParaYatir = new System.Windows.Forms.Label();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.lblParaYatirMiktar = new System.Windows.Forms.Label();
            this.txtbxParaYatirParaMiktari = new System.Windows.Forms.TextBox();
            this.txtbxParaYatirHesapNo = new System.Windows.Forms.TextBox();
            this.tbPgHavaleEt = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHavaleEt = new System.Windows.Forms.Button();
            this.txtbxHavaleMiktar = new System.Windows.Forms.TextBox();
            this.lblHavaleMiktari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxHavaleGonderenHesapNo = new System.Windows.Forms.TextBox();
            this.txtbxHavaleGonderilecekHesapNo = new System.Windows.Forms.TextBox();
            this.tbPgHesapOzeti = new System.Windows.Forms.TabPage();
            this.btnHOzetListele = new System.Windows.Forms.Button();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtGrdVwHesapOzeti = new System.Windows.Forms.DataGridView();
            this.txtbxHesapNoHOzet = new System.Windows.Forms.TextBox();
            this.lblHesapNumarasiHOzet = new System.Windows.Forms.Label();
            this.tbPgHesaplarim = new System.Windows.Forms.TabPage();
            this.txtbxMusteriNoHesaplarim = new System.Windows.Forms.TextBox();
            this.lblMusteriNoHesaplarim = new System.Windows.Forms.Label();
            this.dtGrdVwHesaplarim = new System.Windows.Forms.DataGridView();
            this.btnHesaplarimiListele = new System.Windows.Forms.Button();
            this.tbCntrlMusteriFormu.SuspendLayout();
            this.tbPgParaCekme.SuspendLayout();
            this.grpBxParaCek.SuspendLayout();
            this.tbPgParaYatırma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbPgHavaleEt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbPgHesapOzeti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwHesapOzeti)).BeginInit();
            this.tbPgHesaplarim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwHesaplarim)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlMusteriFormu
            // 
            this.tbCntrlMusteriFormu.Controls.Add(this.tbPgParaCekme);
            this.tbCntrlMusteriFormu.Controls.Add(this.tbPgParaYatırma);
            this.tbCntrlMusteriFormu.Controls.Add(this.tbPgHavaleEt);
            this.tbCntrlMusteriFormu.Controls.Add(this.tbPgHesapOzeti);
            this.tbCntrlMusteriFormu.Controls.Add(this.tbPgHesaplarim);
            this.tbCntrlMusteriFormu.Location = new System.Drawing.Point(12, 10);
            this.tbCntrlMusteriFormu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCntrlMusteriFormu.Name = "tbCntrlMusteriFormu";
            this.tbCntrlMusteriFormu.SelectedIndex = 0;
            this.tbCntrlMusteriFormu.Size = new System.Drawing.Size(690, 341);
            this.tbCntrlMusteriFormu.TabIndex = 0;
            // 
            // tbPgParaCekme
            // 
            this.tbPgParaCekme.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgParaCekme.Controls.Add(this.grpBxParaCek);
            this.tbPgParaCekme.Location = new System.Drawing.Point(4, 25);
            this.tbPgParaCekme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgParaCekme.Name = "tbPgParaCekme";
            this.tbPgParaCekme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgParaCekme.Size = new System.Drawing.Size(682, 312);
            this.tbPgParaCekme.TabIndex = 0;
            this.tbPgParaCekme.Text = "Para Çekme";
            // 
            // grpBxParaCek
            // 
            this.grpBxParaCek.Controls.Add(this.lblBakiyeSonuc);
            this.grpBxParaCek.Controls.Add(this.lblAciklama);
            this.grpBxParaCek.Controls.Add(this.lblHesapNumarasi);
            this.grpBxParaCek.Controls.Add(this.btnParaCek);
            this.grpBxParaCek.Controls.Add(this.lblMiktar);
            this.grpBxParaCek.Controls.Add(this.txtbxParaCekmekMiktari);
            this.grpBxParaCek.Controls.Add(this.txtbxParaCekmeHesapNumarasi);
            this.grpBxParaCek.Location = new System.Drawing.Point(113, 38);
            this.grpBxParaCek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxParaCek.Name = "grpBxParaCek";
            this.grpBxParaCek.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxParaCek.Size = new System.Drawing.Size(433, 248);
            this.grpBxParaCek.TabIndex = 5;
            this.grpBxParaCek.TabStop = false;
            this.grpBxParaCek.Text = "Hesap Bilgileri";
            // 
            // lblBakiyeSonuc
            // 
            this.lblBakiyeSonuc.AutoSize = true;
            this.lblBakiyeSonuc.Location = new System.Drawing.Point(175, 188);
            this.lblBakiyeSonuc.Name = "lblBakiyeSonuc";
            this.lblBakiyeSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblBakiyeSonuc.TabIndex = 7;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(80, 42);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(234, 17);
            this.lblAciklama.TabIndex = 5;
            this.lblAciklama.Text = "Günlük para çekme limiti 750 TL\'dir.";
            // 
            // lblHesapNumarasi
            // 
            this.lblHesapNumarasi.AutoSize = true;
            this.lblHesapNumarasi.Location = new System.Drawing.Point(33, 88);
            this.lblHesapNumarasi.Name = "lblHesapNumarasi";
            this.lblHesapNumarasi.Size = new System.Drawing.Size(117, 17);
            this.lblHesapNumarasi.TabIndex = 0;
            this.lblHesapNumarasi.Text = "Hesap Numarasi:";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(272, 188);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(102, 34);
            this.btnParaCek.TabIndex = 4;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(33, 144);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "Miktar:";
            // 
            // txtbxParaCekmekMiktari
            // 
            this.txtbxParaCekmekMiktari.Location = new System.Drawing.Point(172, 139);
            this.txtbxParaCekmekMiktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxParaCekmekMiktari.Name = "txtbxParaCekmekMiktari";
            this.txtbxParaCekmekMiktari.Size = new System.Drawing.Size(112, 22);
            this.txtbxParaCekmekMiktari.TabIndex = 3;
            this.txtbxParaCekmekMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxParaCekmekMiktari_KeyPress);
            // 
            // txtbxParaCekmeHesapNumarasi
            // 
            this.txtbxParaCekmeHesapNumarasi.Location = new System.Drawing.Point(172, 88);
            this.txtbxParaCekmeHesapNumarasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxParaCekmeHesapNumarasi.Name = "txtbxParaCekmeHesapNumarasi";
            this.txtbxParaCekmeHesapNumarasi.Size = new System.Drawing.Size(112, 22);
            this.txtbxParaCekmeHesapNumarasi.TabIndex = 2;
            this.txtbxParaCekmeHesapNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxParaCekmeHesapNumarasi_KeyPress);
            // 
            // tbPgParaYatırma
            // 
            this.tbPgParaYatırma.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgParaYatırma.Controls.Add(this.groupBox1);
            this.tbPgParaYatırma.Location = new System.Drawing.Point(4, 25);
            this.tbPgParaYatırma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgParaYatırma.Name = "tbPgParaYatırma";
            this.tbPgParaYatırma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgParaYatırma.Size = new System.Drawing.Size(682, 312);
            this.tbPgParaYatırma.TabIndex = 1;
            this.tbPgParaYatırma.Text = "Para Yatırma";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHesapNumarasiParaYatir);
            this.groupBox1.Controls.Add(this.btnParaYatir);
            this.groupBox1.Controls.Add(this.lblParaYatirMiktar);
            this.groupBox1.Controls.Add(this.txtbxParaYatirParaMiktari);
            this.groupBox1.Controls.Add(this.txtbxParaYatirHesapNo);
            this.groupBox1.Location = new System.Drawing.Point(125, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(433, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // lblHesapNumarasiParaYatir
            // 
            this.lblHesapNumarasiParaYatir.AutoSize = true;
            this.lblHesapNumarasiParaYatir.Location = new System.Drawing.Point(82, 72);
            this.lblHesapNumarasiParaYatir.Name = "lblHesapNumarasiParaYatir";
            this.lblHesapNumarasiParaYatir.Size = new System.Drawing.Size(117, 17);
            this.lblHesapNumarasiParaYatir.TabIndex = 0;
            this.lblHesapNumarasiParaYatir.Text = "Hesap Numarasi:";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(213, 146);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(102, 34);
            this.btnParaYatir.TabIndex = 4;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // lblParaYatirMiktar
            // 
            this.lblParaYatirMiktar.AutoSize = true;
            this.lblParaYatirMiktar.Location = new System.Drawing.Point(82, 110);
            this.lblParaYatirMiktar.Name = "lblParaYatirMiktar";
            this.lblParaYatirMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblParaYatirMiktar.TabIndex = 1;
            this.lblParaYatirMiktar.Text = "Miktar:";
            // 
            // txtbxParaYatirParaMiktari
            // 
            this.txtbxParaYatirParaMiktari.Location = new System.Drawing.Point(204, 110);
            this.txtbxParaYatirParaMiktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxParaYatirParaMiktari.Name = "txtbxParaYatirParaMiktari";
            this.txtbxParaYatirParaMiktari.Size = new System.Drawing.Size(112, 22);
            this.txtbxParaYatirParaMiktari.TabIndex = 3;
            this.txtbxParaYatirParaMiktari.TextChanged += new System.EventHandler(this.txtbxParaYatirParaMiktari_TextChanged);
            this.txtbxParaYatirParaMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxParaYatirParaMiktari_KeyPress);
            // 
            // txtbxParaYatirHesapNo
            // 
            this.txtbxParaYatirHesapNo.Location = new System.Drawing.Point(204, 70);
            this.txtbxParaYatirHesapNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxParaYatirHesapNo.Name = "txtbxParaYatirHesapNo";
            this.txtbxParaYatirHesapNo.Size = new System.Drawing.Size(112, 22);
            this.txtbxParaYatirHesapNo.TabIndex = 2;
            this.txtbxParaYatirHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxParaYatirHesapNo_KeyPress);
            // 
            // tbPgHavaleEt
            // 
            this.tbPgHavaleEt.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgHavaleEt.Controls.Add(this.groupBox2);
            this.tbPgHavaleEt.Location = new System.Drawing.Point(4, 25);
            this.tbPgHavaleEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgHavaleEt.Name = "tbPgHavaleEt";
            this.tbPgHavaleEt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgHavaleEt.Size = new System.Drawing.Size(682, 312);
            this.tbPgHavaleEt.TabIndex = 2;
            this.tbPgHavaleEt.Text = "Hesaba Havale Et";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHavaleEt);
            this.groupBox2.Controls.Add(this.txtbxHavaleMiktar);
            this.groupBox2.Controls.Add(this.lblHavaleMiktari);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbxHavaleGonderenHesapNo);
            this.groupBox2.Controls.Add(this.txtbxHavaleGonderilecekHesapNo);
            this.groupBox2.Location = new System.Drawing.Point(92, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(459, 284);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // btnHavaleEt
            // 
            this.btnHavaleEt.Location = new System.Drawing.Point(123, 222);
            this.btnHavaleEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHavaleEt.Name = "btnHavaleEt";
            this.btnHavaleEt.Size = new System.Drawing.Size(102, 34);
            this.btnHavaleEt.TabIndex = 7;
            this.btnHavaleEt.Text = "Havale Et";
            this.btnHavaleEt.UseVisualStyleBackColor = true;
            this.btnHavaleEt.Click += new System.EventHandler(this.btnHavaleEt_Click);
            // 
            // txtbxHavaleMiktar
            // 
            this.txtbxHavaleMiktar.Location = new System.Drawing.Point(248, 128);
            this.txtbxHavaleMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxHavaleMiktar.Name = "txtbxHavaleMiktar";
            this.txtbxHavaleMiktar.Size = new System.Drawing.Size(134, 22);
            this.txtbxHavaleMiktar.TabIndex = 6;
            this.txtbxHavaleMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHavaleMiktar_KeyPress);
            // 
            // lblHavaleMiktari
            // 
            this.lblHavaleMiktari.AutoSize = true;
            this.lblHavaleMiktari.Location = new System.Drawing.Point(14, 130);
            this.lblHavaleMiktari.Name = "lblHavaleMiktari";
            this.lblHavaleMiktari.Size = new System.Drawing.Size(171, 17);
            this.lblHavaleMiktari.TabIndex = 5;
            this.lblHavaleMiktari.Text = "Gönderilecek Para Tutarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Havale Yapılacak Hesap Numarasi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Havale Yapacak Hesap Numarasi:";
            // 
            // txtbxHavaleGonderenHesapNo
            // 
            this.txtbxHavaleGonderenHesapNo.Location = new System.Drawing.Point(243, 182);
            this.txtbxHavaleGonderenHesapNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxHavaleGonderenHesapNo.Name = "txtbxHavaleGonderenHesapNo";
            this.txtbxHavaleGonderenHesapNo.Size = new System.Drawing.Size(139, 22);
            this.txtbxHavaleGonderenHesapNo.TabIndex = 3;
            this.txtbxHavaleGonderenHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHavaleGonderenHesapNo_KeyPress);
            // 
            // txtbxHavaleGonderilecekHesapNo
            // 
            this.txtbxHavaleGonderilecekHesapNo.Location = new System.Drawing.Point(248, 72);
            this.txtbxHavaleGonderilecekHesapNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxHavaleGonderilecekHesapNo.Name = "txtbxHavaleGonderilecekHesapNo";
            this.txtbxHavaleGonderilecekHesapNo.Size = new System.Drawing.Size(134, 22);
            this.txtbxHavaleGonderilecekHesapNo.TabIndex = 2;
            this.txtbxHavaleGonderilecekHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHavaleGonderilecekHesapNo_KeyPress);
            // 
            // tbPgHesapOzeti
            // 
            this.tbPgHesapOzeti.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgHesapOzeti.Controls.Add(this.btnHOzetListele);
            this.tbPgHesapOzeti.Controls.Add(this.dateTimeBitis);
            this.tbPgHesapOzeti.Controls.Add(this.dateTimeBaslangic);
            this.tbPgHesapOzeti.Controls.Add(this.dtGrdVwHesapOzeti);
            this.tbPgHesapOzeti.Controls.Add(this.txtbxHesapNoHOzet);
            this.tbPgHesapOzeti.Controls.Add(this.lblHesapNumarasiHOzet);
            this.tbPgHesapOzeti.Location = new System.Drawing.Point(4, 25);
            this.tbPgHesapOzeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgHesapOzeti.Name = "tbPgHesapOzeti";
            this.tbPgHesapOzeti.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgHesapOzeti.Size = new System.Drawing.Size(682, 312);
            this.tbPgHesapOzeti.TabIndex = 3;
            this.tbPgHesapOzeti.Text = "Hesap Ozeti";
            // 
            // btnHOzetListele
            // 
            this.btnHOzetListele.Location = new System.Drawing.Point(536, 38);
            this.btnHOzetListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHOzetListele.Name = "btnHOzetListele";
            this.btnHOzetListele.Size = new System.Drawing.Size(93, 26);
            this.btnHOzetListele.TabIndex = 6;
            this.btnHOzetListele.Text = "Listele";
            this.btnHOzetListele.UseVisualStyleBackColor = true;
            this.btnHOzetListele.Click += new System.EventHandler(this.btnHOzetListele_Click);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Location = new System.Drawing.Point(330, 50);
            this.dateTimeBitis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(178, 22);
            this.dateTimeBitis.TabIndex = 5;
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Location = new System.Drawing.Point(330, 25);
            this.dateTimeBaslangic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(178, 22);
            this.dateTimeBaslangic.TabIndex = 4;
            // 
            // dtGrdVwHesapOzeti
            // 
            this.dtGrdVwHesapOzeti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdVwHesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwHesapOzeti.Location = new System.Drawing.Point(16, 111);
            this.dtGrdVwHesapOzeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrdVwHesapOzeti.Name = "dtGrdVwHesapOzeti";
            this.dtGrdVwHesapOzeti.RowHeadersWidth = 62;
            this.dtGrdVwHesapOzeti.RowTemplate.Height = 28;
            this.dtGrdVwHesapOzeti.Size = new System.Drawing.Size(637, 184);
            this.dtGrdVwHesapOzeti.TabIndex = 3;
            // 
            // txtbxHesapNoHOzet
            // 
            this.txtbxHesapNoHOzet.Location = new System.Drawing.Point(164, 26);
            this.txtbxHesapNoHOzet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxHesapNoHOzet.Name = "txtbxHesapNoHOzet";
            this.txtbxHesapNoHOzet.Size = new System.Drawing.Size(130, 22);
            this.txtbxHesapNoHOzet.TabIndex = 2;
            this.txtbxHesapNoHOzet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHesapNoHOzet_KeyPress);
            // 
            // lblHesapNumarasiHOzet
            // 
            this.lblHesapNumarasiHOzet.AutoSize = true;
            this.lblHesapNumarasiHOzet.Location = new System.Drawing.Point(12, 26);
            this.lblHesapNumarasiHOzet.Name = "lblHesapNumarasiHOzet";
            this.lblHesapNumarasiHOzet.Size = new System.Drawing.Size(117, 17);
            this.lblHesapNumarasiHOzet.TabIndex = 1;
            this.lblHesapNumarasiHOzet.Text = "Hesap Numarasi:";
            // 
            // tbPgHesaplarim
            // 
            this.tbPgHesaplarim.BackColor = System.Drawing.Color.Cornsilk;
            this.tbPgHesaplarim.Controls.Add(this.txtbxMusteriNoHesaplarim);
            this.tbPgHesaplarim.Controls.Add(this.lblMusteriNoHesaplarim);
            this.tbPgHesaplarim.Controls.Add(this.dtGrdVwHesaplarim);
            this.tbPgHesaplarim.Controls.Add(this.btnHesaplarimiListele);
            this.tbPgHesaplarim.Location = new System.Drawing.Point(4, 25);
            this.tbPgHesaplarim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgHesaplarim.Name = "tbPgHesaplarim";
            this.tbPgHesaplarim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPgHesaplarim.Size = new System.Drawing.Size(682, 312);
            this.tbPgHesaplarim.TabIndex = 4;
            this.tbPgHesaplarim.Text = "Hesaplarim";
            // 
            // txtbxMusteriNoHesaplarim
            // 
            this.txtbxMusteriNoHesaplarim.Location = new System.Drawing.Point(395, 16);
            this.txtbxMusteriNoHesaplarim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxMusteriNoHesaplarim.Name = "txtbxMusteriNoHesaplarim";
            this.txtbxMusteriNoHesaplarim.Size = new System.Drawing.Size(89, 22);
            this.txtbxMusteriNoHesaplarim.TabIndex = 10;
            // 
            // lblMusteriNoHesaplarim
            // 
            this.lblMusteriNoHesaplarim.AutoSize = true;
            this.lblMusteriNoHesaplarim.Location = new System.Drawing.Point(300, 16);
            this.lblMusteriNoHesaplarim.Name = "lblMusteriNoHesaplarim";
            this.lblMusteriNoHesaplarim.Size = new System.Drawing.Size(80, 17);
            this.lblMusteriNoHesaplarim.TabIndex = 9;
            this.lblMusteriNoHesaplarim.Text = "Musteri No:";
            // 
            // dtGrdVwHesaplarim
            // 
            this.dtGrdVwHesaplarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwHesaplarim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGrdVwHesaplarim.Location = new System.Drawing.Point(3, 55);
            this.dtGrdVwHesaplarim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrdVwHesaplarim.Name = "dtGrdVwHesaplarim";
            this.dtGrdVwHesaplarim.RowHeadersWidth = 62;
            this.dtGrdVwHesaplarim.RowTemplate.Height = 28;
            this.dtGrdVwHesaplarim.Size = new System.Drawing.Size(676, 255);
            this.dtGrdVwHesaplarim.TabIndex = 8;
            // 
            // btnHesaplarimiListele
            // 
            this.btnHesaplarimiListele.Location = new System.Drawing.Point(45, 16);
            this.btnHesaplarimiListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesaplarimiListele.Name = "btnHesaplarimiListele";
            this.btnHesaplarimiListele.Size = new System.Drawing.Size(93, 26);
            this.btnHesaplarimiListele.TabIndex = 7;
            this.btnHesaplarimiListele.Text = "Listele";
            this.btnHesaplarimiListele.UseVisualStyleBackColor = true;
            this.btnHesaplarimiListele.Click += new System.EventHandler(this.btnHesaplarimiListele_Click);
            // 
            // MusteriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.tbCntrlMusteriFormu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MusteriFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Musteri Form Ekranı";
            this.Load += new System.EventHandler(this.MusteriFormu_Load);
            this.tbCntrlMusteriFormu.ResumeLayout(false);
            this.tbPgParaCekme.ResumeLayout(false);
            this.grpBxParaCek.ResumeLayout(false);
            this.grpBxParaCek.PerformLayout();
            this.tbPgParaYatırma.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbPgHavaleEt.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbPgHesapOzeti.ResumeLayout(false);
            this.tbPgHesapOzeti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwHesapOzeti)).EndInit();
            this.tbPgHesaplarim.ResumeLayout(false);
            this.tbPgHesaplarim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwHesaplarim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlMusteriFormu;
        private System.Windows.Forms.TabPage tbPgParaCekme;
        private System.Windows.Forms.TabPage tbPgParaYatırma;
        private System.Windows.Forms.TabPage tbPgHavaleEt;
        private System.Windows.Forms.TabPage tbPgHesapOzeti;
        private System.Windows.Forms.TabPage tbPgHesaplarim;
        private System.Windows.Forms.TextBox txtbxParaCekmekMiktari;
        private System.Windows.Forms.TextBox txtbxParaCekmeHesapNumarasi;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblHesapNumarasi;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.GroupBox grpBxParaCek;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHesapNumarasiParaYatir;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Label lblParaYatirMiktar;
        private System.Windows.Forms.TextBox txtbxParaYatirParaMiktari;
        private System.Windows.Forms.TextBox txtbxParaYatirHesapNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxHavaleGonderenHesapNo;
        private System.Windows.Forms.TextBox txtbxHavaleGonderilecekHesapNo;
        private System.Windows.Forms.Label lblHavaleMiktari;
        private System.Windows.Forms.TextBox txtbxHavaleMiktar;
        private System.Windows.Forms.Label lblHesapNumarasiHOzet;
        private System.Windows.Forms.TextBox txtbxHesapNoHOzet;
        private System.Windows.Forms.DataGridView dtGrdVwHesapOzeti;
        private System.Windows.Forms.Button btnHOzetListele;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.Button btnHesaplarimiListele;
        private System.Windows.Forms.DataGridView dtGrdVwHesaplarim;
        private System.Windows.Forms.Button btnHavaleEt;
        private System.Windows.Forms.Label lblMusteriNoHesaplarim;
        private System.Windows.Forms.TextBox txtbxMusteriNoHesaplarim;
        private System.Windows.Forms.Label lblBakiyeSonuc;
    }
}