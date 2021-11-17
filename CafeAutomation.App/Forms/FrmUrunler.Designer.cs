
namespace CafeAutomation.App.Forms
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 15;
            this.lstUrunler.Location = new System.Drawing.Point(6, 22);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(606, 304);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(98, 343);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(199, 23);
            this.txtUrunAd.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(98, 372);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(199, 23);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(98, 401);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(199, 23);
            this.txtKategori.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 442);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 39);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(105, 442);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 39);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(531, 551);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(93, 39);
            this.btnGeriDon.TabIndex = 10;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(204, 442);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 39);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.lstUrunler);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.btnGeriDon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1040, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 596);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 635);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}