
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparis));
            this.lblMasaIsmi = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSogukIcecekler = new System.Windows.Forms.Button();
            this.btnSicakIcecekler = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnYemekler = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasaIsmi
            // 
            this.lblMasaIsmi.AutoSize = true;
            this.lblMasaIsmi.Location = new System.Drawing.Point(170, 524);
            this.lblMasaIsmi.Name = "lblMasaIsmi";
            this.lblMasaIsmi.Size = new System.Drawing.Size(0, 15);
            this.lblMasaIsmi.TabIndex = 0;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(170, 268);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowTemplate.Height = 25;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(501, 242);
            this.dgvListe.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplamTutar.Location = new System.Drawing.Point(610, 524);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 15);
            this.lblToplamTutar.TabIndex = 2;
            // 
            // btnSogukIcecekler
            // 
            this.btnSogukIcecekler.Location = new System.Drawing.Point(143, 164);
            this.btnSogukIcecekler.Name = "btnSogukIcecekler";
            this.btnSogukIcecekler.Size = new System.Drawing.Size(86, 45);
            this.btnSogukIcecekler.TabIndex = 5;
            this.btnSogukIcecekler.Text = "SOĞUK İÇECEKLER";
            this.btnSogukIcecekler.UseVisualStyleBackColor = true;
            this.btnSogukIcecekler.Click += new System.EventHandler(this.btnSogukIcecekler_Click);
            // 
            // btnSicakIcecekler
            // 
            this.btnSicakIcecekler.Location = new System.Drawing.Point(36, 164);
            this.btnSicakIcecekler.Name = "btnSicakIcecekler";
            this.btnSicakIcecekler.Size = new System.Drawing.Size(84, 45);
            this.btnSicakIcecekler.TabIndex = 4;
            this.btnSicakIcecekler.Text = "SICAK İÇECEKLER";
            this.btnSicakIcecekler.UseVisualStyleBackColor = true;
            this.btnSicakIcecekler.Click += new System.EventHandler(this.btnSicakIcecekler_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.Location = new System.Drawing.Point(143, 94);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(86, 45);
            this.btnTatlilar.TabIndex = 3;
            this.btnTatlilar.Text = "TATLILAR";
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnYemekler
            // 
            this.btnYemekler.Location = new System.Drawing.Point(36, 94);
            this.btnYemekler.Name = "btnYemekler";
            this.btnYemekler.Size = new System.Drawing.Size(84, 45);
            this.btnYemekler.TabIndex = 2;
            this.btnYemekler.Text = "YEMEKLER";
            this.btnYemekler.UseVisualStyleBackColor = true;
            this.btnYemekler.Click += new System.EventHandler(this.btnYemekler_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.Location = new System.Drawing.Point(143, 18);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(86, 45);
            this.btnFastFood.TabIndex = 1;
            this.btnFastFood.Text = "FAST FOOD";
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.Location = new System.Drawing.Point(36, 18);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(84, 45);
            this.btnCorbalar.TabIndex = 0;
            this.btnCorbalar.Text = "ÇORBALAR";
            this.btnCorbalar.UseVisualStyleBackColor = true;
            this.btnCorbalar.Click += new System.EventHandler(this.btnCorbalar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(466, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet :";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(527, 12);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 23);
            this.cmbUrunler.TabIndex = 6;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(527, 41);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(121, 23);
            this.txtAdet.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(527, 70);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 45);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(169, 561);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 45);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(296, 561);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 45);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(423, 561);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(121, 45);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Location = new System.Drawing.Point(550, 561);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(121, 45);
            this.btnAdisyon.TabIndex = 12;
            this.btnAdisyon.Text = "ADİSYON";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnMasayiKapat
            // 
            this.btnMasayiKapat.Location = new System.Drawing.Point(550, 612);
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(462, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Tutar :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSogukIcecekler);
            this.panel1.Controls.Add(this.btnFastFood);
            this.panel1.Controls.Add(this.btnSicakIcecekler);
            this.panel1.Controls.Add(this.btnCorbalar);
            this.panel1.Controls.Add(this.btnTatlilar);
            this.panel1.Controls.Add(this.btnYemekler);
            this.panel1.Location = new System.Drawing.Point(160, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 227);
            this.panel1.TabIndex = 15;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 714);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.lblMasaIsmi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSiparis_FormClosed);
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMasaIsmi;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblToplamTutar;
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
        private System.Windows.Forms.Button btnSogukIcecekler;
        private System.Windows.Forms.Button btnSicakIcecekler;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnYemekler;
        private System.Windows.Forms.Panel panel1;
    }
}