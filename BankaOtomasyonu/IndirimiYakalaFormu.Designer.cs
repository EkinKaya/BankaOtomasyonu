namespace BankaOtomasyonu
{
    partial class IndirimiYakalaFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndirimiYakalaFormu));
            this.lblIndirimAciklama = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIndirimiYakala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndirimAciklama
            // 
            this.lblIndirimAciklama.AutoSize = true;
            this.lblIndirimAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimAciklama.Location = new System.Drawing.Point(46, 119);
            this.lblIndirimAciklama.Name = "lblIndirimAciklama";
            this.lblIndirimAciklama.Size = new System.Drawing.Size(732, 25);
            this.lblIndirimAciklama.TabIndex = 0;
            this.lblIndirimAciklama.Text = "TrendyolYemek indirimi için her gün ziyaret et %70 varan indirimleri yakala!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnIndirimiYakala
            // 
            this.btnIndirimiYakala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndirimiYakala.Location = new System.Drawing.Point(298, 190);
            this.btnIndirimiYakala.Name = "btnIndirimiYakala";
            this.btnIndirimiYakala.Size = new System.Drawing.Size(230, 71);
            this.btnIndirimiYakala.TabIndex = 2;
            this.btnIndirimiYakala.Text = "İndirimi Yakala";
            this.btnIndirimiYakala.UseVisualStyleBackColor = true;
            this.btnIndirimiYakala.Click += new System.EventHandler(this.btnIndirimiYakala_Click);
            // 
            // IndirimiYakalaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(910, 512);
            this.Controls.Add(this.btnIndirimiYakala);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIndirimAciklama);
            this.Name = "IndirimiYakalaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Indirimi Yakala";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndirimAciklama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIndirimiYakala;
    }
}