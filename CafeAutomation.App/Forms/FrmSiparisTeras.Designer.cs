
namespace CafeAutomation.App.Forms
{
    partial class FrmSiparisTeras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisTeras));
            this.btnSicakIcecekler = new System.Windows.Forms.Button();
            this.btnYemekler = new System.Windows.Forms.Button();
            this.btnSogukIcecekler = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.btnAdisyon = new System.Windows.Forms.Button();
            this.btnMasayiKapat = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.lblMasaIsmi = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSicakIcecekler
            // 
            this.btnSicakIcecekler.Location = new System.Drawing.Point(69, 162);
            this.btnSicakIcecekler.Name = "btnSicakIcecekler";
            this.btnSicakIcecekler.Size = new System.Drawing.Size(75, 47);
            this.btnSicakIcecekler.TabIndex = 5;
            this.btnSicakIcecekler.Text = "SICAK İÇECEKLER";
            this.btnSicakIcecekler.UseVisualStyleBackColor = true;
            this.btnSicakIcecekler.Click += new System.EventHandler(this.btnSicakIcecekler_Click);
            // 
            // btnYemekler
            // 
            this.btnYemekler.Location = new System.Drawing.Point(69, 90);
            this.btnYemekler.Name = "btnYemekler";
            this.btnYemekler.Size = new System.Drawing.Size(75, 46);
            this.btnYemekler.TabIndex = 4;
            this.btnYemekler.Text = "YEMEKLER";
            this.btnYemekler.UseVisualStyleBackColor = true;
            this.btnYemekler.Click += new System.EventHandler(this.btnYemekler_Click);
            // 
            // btnSogukIcecekler
            // 
            this.btnSogukIcecekler.Location = new System.Drawing.Point(182, 162);
            this.btnSogukIcecekler.Name = "btnSogukIcecekler";
            this.btnSogukIcecekler.Size = new System.Drawing.Size(75, 47);
            this.btnSogukIcecekler.TabIndex = 3;
            this.btnSogukIcecekler.Text = "SOĞUK İÇECEKLER";
            this.btnSogukIcecekler.UseVisualStyleBackColor = true;
            this.btnSogukIcecekler.Click += new System.EventHandler(this.btnSogukIcecekler_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.Location = new System.Drawing.Point(182, 90);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(75, 46);
            this.btnTatlilar.TabIndex = 2;
            this.btnTatlilar.Text = "TATLILAR";
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.Location = new System.Drawing.Point(182, 17);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(75, 49);
            this.btnFastFood.TabIndex = 1;
            this.btnFastFood.Text = "FAST FOOD";
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.Location = new System.Drawing.Point(67, 17);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(75, 49);
            this.btnCorbalar.TabIndex = 0;
            this.btnCorbalar.Text = "ÇORBALAR";
            this.btnCorbalar.UseVisualStyleBackColor = true;
            this.btnCorbalar.Click += new System.EventHandler(this.btnCorbalar_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(749, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(169, 53);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(305, 536);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(82, 59);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(400, 536);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 59);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.Location = new System.Drawing.Point(486, 536);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(82, 59);
            this.btnGeriDön.TabIndex = 5;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Location = new System.Drawing.Point(582, 536);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(82, 59);
            this.btnAdisyon.TabIndex = 6;
            this.btnAdisyon.Text = "btnAdisyon";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnMasayiKapat
            // 
            this.btnMasayiKapat.Location = new System.Drawing.Point(668, 536);
            this.btnMasayiKapat.Name = "btnMasayiKapat";
            this.btnMasayiKapat.Size = new System.Drawing.Size(82, 59);
            this.btnMasayiKapat.TabIndex = 7;
            this.btnMasayiKapat.Text = "Masayı Kapat";
            this.btnMasayiKapat.UseVisualStyleBackColor = true;
            this.btnMasayiKapat.Click += new System.EventHandler(this.btnMasayiKapat_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(749, 60);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(169, 23);
            this.txtAdet.TabIndex = 8;
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(749, 26);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(169, 23);
            this.cmbUrunler.TabIndex = 9;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(305, 289);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowTemplate.Height = 25;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(445, 220);
            this.dgvListe.TabIndex = 10;
            // 
            // lblMasaIsmi
            // 
            this.lblMasaIsmi.AutoSize = true;
            this.lblMasaIsmi.BackColor = System.Drawing.Color.Transparent;
            this.lblMasaIsmi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMasaIsmi.Location = new System.Drawing.Point(305, 512);
            this.lblMasaIsmi.Name = "lblMasaIsmi";
            this.lblMasaIsmi.Size = new System.Drawing.Size(38, 15);
            this.lblMasaIsmi.TabIndex = 11;
            this.lblMasaIsmi.Text = "label1";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplamTutar.Location = new System.Drawing.Point(691, 512);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(38, 15);
            this.lblToplamTutar.TabIndex = 12;
            this.lblToplamTutar.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(582, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "TOPLAM TUTAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(670, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(692, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adet :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSogukIcecekler);
            this.panel1.Controls.Add(this.btnSicakIcecekler);
            this.panel1.Controls.Add(this.btnCorbalar);
            this.panel1.Controls.Add(this.btnYemekler);
            this.panel1.Controls.Add(this.btnTatlilar);
            this.panel1.Controls.Add(this.btnFastFood);
            this.panel1.Location = new System.Drawing.Point(305, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 234);
            this.panel1.TabIndex = 16;
            // 
            // FrmSiparisTeras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblMasaIsmi);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnMasayiKapat);
            this.Controls.Add(this.btnAdisyon);
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSiparisTeras";
            this.Text = "FrmSiparisTeras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSiparisTeras_FormClosed);
            this.Load += new System.EventHandler(this.FrmSiparisTeras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.Button btnAdisyon;
        private System.Windows.Forms.Button btnMasayiKapat;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblToplamTutar;
        public System.Windows.Forms.Label lblMasaIsmi;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSicakIcecekler;
        private System.Windows.Forms.Button btnYemekler;
        private System.Windows.Forms.Button btnSogukIcecekler;
        private System.Windows.Forms.Button btnTatlilar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}