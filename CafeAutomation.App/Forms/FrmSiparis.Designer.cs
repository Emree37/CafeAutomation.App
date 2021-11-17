
namespace CafeAutomation.App.Forms
{
    partial class FrmSiparis
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
            this.lblMasaIsmi = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnAdisyon = new System.Windows.Forms.Button();
            this.btnMasayiKapat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasaIsmi
            // 
            this.lblMasaIsmi.AutoSize = true;
            this.lblMasaIsmi.Location = new System.Drawing.Point(287, 33);
            this.lblMasaIsmi.Name = "lblMasaIsmi";
            this.lblMasaIsmi.Size = new System.Drawing.Size(0, 15);
            this.lblMasaIsmi.TabIndex = 0;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(287, 69);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowTemplate.Height = 25;
            this.dgvListe.Size = new System.Drawing.Size(501, 186);
            this.dgvListe.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(563, 400);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 15);
            this.lblToplamTutar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFastFood);
            this.groupBox1.Controls.Add(this.btnCorbalar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriler";
            // 
            // btnFastFood
            // 
            this.btnFastFood.Location = new System.Drawing.Point(108, 22);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(86, 45);
            this.btnFastFood.TabIndex = 1;
            this.btnFastFood.Text = "FastFood";
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.Location = new System.Drawing.Point(7, 23);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(84, 45);
            this.btnCorbalar.TabIndex = 0;
            this.btnCorbalar.Text = "Çorbalar";
            this.btnCorbalar.UseVisualStyleBackColor = true;
            this.btnCorbalar.Click += new System.EventHandler(this.btnCorbalar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet :";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(96, 274);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 23);
            this.cmbUrunler.TabIndex = 6;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(96, 303);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(121, 23);
            this.txtAdet.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(96, 332);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 45);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(287, 281);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 45);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(414, 281);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 45);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(541, 281);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(121, 45);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Location = new System.Drawing.Point(668, 281);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(121, 45);
            this.btnAdisyon.TabIndex = 12;
            this.btnAdisyon.Text = "ADİSYON";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnMasayiKapat
            // 
            this.btnMasayiKapat.Location = new System.Drawing.Point(668, 332);
            this.btnMasayiKapat.Name = "btnMasayiKapat";
            this.btnMasayiKapat.Size = new System.Drawing.Size(121, 45);
            this.btnMasayiKapat.TabIndex = 13;
            this.btnMasayiKapat.Text = "MASAYI KAPAT";
            this.btnMasayiKapat.UseVisualStyleBackColor = true;
            this.btnMasayiKapat.Click += new System.EventHandler(this.btnMasayiKapat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Tutar :";
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMasayiKapat);
            this.Controls.Add(this.btnAdisyon);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.lblMasaIsmi);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSiparis_FormClosed);
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMasaIsmi;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnAdisyon;
        private System.Windows.Forms.Button btnMasayiKapat;
        private System.Windows.Forms.Label label3;
    }
}