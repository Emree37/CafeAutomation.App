
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
            this.btnYemekler = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.btnSicakIcecekler = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnSogukIcecekler = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnTusSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMasaIsmi
            // 
            this.lblMasaIsmi.AutoSize = true;
            this.lblMasaIsmi.BackColor = System.Drawing.Color.Transparent;
            this.lblMasaIsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasaIsmi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMasaIsmi.Location = new System.Drawing.Point(242, 531);
            this.lblMasaIsmi.Name = "lblMasaIsmi";
            this.lblMasaIsmi.Size = new System.Drawing.Size(0, 21);
            this.lblMasaIsmi.TabIndex = 0;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(242, 267);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowTemplate.Height = 25;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(628, 242);
            this.dgvListe.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplamTutar.Location = new System.Drawing.Point(710, 531);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 21);
            this.lblToplamTutar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(584, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(584, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet :";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(660, 9);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(374, 23);
            this.cmbUrunler.TabIndex = 6;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(660, 43);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.ReadOnly = true;
            this.txtAdet.Size = new System.Drawing.Size(198, 23);
            this.txtAdet.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Location = new System.Drawing.Point(890, 154);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 93);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIptal.BackgroundImage")));
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIptal.Location = new System.Drawing.Point(241, 582);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 72);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(368, 582);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 72);
            this.btnSil.TabIndex = 10;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeriDon.BackgroundImage")));
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.Location = new System.Drawing.Point(495, 582);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(121, 72);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdisyon.BackgroundImage")));
            this.btnAdisyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdisyon.Location = new System.Drawing.Point(622, 582);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(121, 72);
            this.btnAdisyon.TabIndex = 12;
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnMasayiKapat
            // 
            this.btnMasayiKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMasayiKapat.BackgroundImage")));
            this.btnMasayiKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasayiKapat.Location = new System.Drawing.Point(749, 582);
            this.btnMasayiKapat.Name = "btnMasayiKapat";
            this.btnMasayiKapat.Size = new System.Drawing.Size(121, 72);
            this.btnMasayiKapat.TabIndex = 13;
            this.btnMasayiKapat.UseVisualStyleBackColor = true;
            this.btnMasayiKapat.Click += new System.EventHandler(this.btnMasayiKapat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(562, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Tutar :";
            // 
            // btnYemekler
            // 
            this.btnYemekler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYemekler.BackgroundImage")));
            this.btnYemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYemekler.Location = new System.Drawing.Point(406, 114);
            this.btnYemekler.Name = "btnYemekler";
            this.btnYemekler.Size = new System.Drawing.Size(143, 93);
            this.btnYemekler.TabIndex = 2;
            this.btnYemekler.UseVisualStyleBackColor = true;
            this.btnYemekler.Click += new System.EventHandler(this.btnYemekler_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTatlilar.BackgroundImage")));
            this.btnTatlilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTatlilar.Location = new System.Drawing.Point(71, 114);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(136, 93);
            this.btnTatlilar.TabIndex = 3;
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorbalar.BackgroundImage")));
            this.btnCorbalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorbalar.Location = new System.Drawing.Point(71, 9);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(136, 97);
            this.btnCorbalar.TabIndex = 0;
            this.btnCorbalar.UseVisualStyleBackColor = true;
            this.btnCorbalar.Click += new System.EventHandler(this.btnCorbalar_Click);
            // 
            // btnSicakIcecekler
            // 
            this.btnSicakIcecekler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSicakIcecekler.BackgroundImage")));
            this.btnSicakIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSicakIcecekler.Location = new System.Drawing.Point(242, 114);
            this.btnSicakIcecekler.Name = "btnSicakIcecekler";
            this.btnSicakIcecekler.Size = new System.Drawing.Size(145, 93);
            this.btnSicakIcecekler.TabIndex = 4;
            this.btnSicakIcecekler.UseVisualStyleBackColor = true;
            this.btnSicakIcecekler.Click += new System.EventHandler(this.btnSicakIcecekler_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFastFood.BackgroundImage")));
            this.btnFastFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastFood.Location = new System.Drawing.Point(242, 9);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(139, 97);
            this.btnFastFood.TabIndex = 1;
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnSogukIcecekler
            // 
            this.btnSogukIcecekler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSogukIcecekler.BackgroundImage")));
            this.btnSogukIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSogukIcecekler.Location = new System.Drawing.Point(406, 12);
            this.btnSogukIcecekler.Name = "btnSogukIcecekler";
            this.btnSogukIcecekler.Size = new System.Drawing.Size(143, 97);
            this.btnSogukIcecekler.TabIndex = 5;
            this.btnSogukIcecekler.UseVisualStyleBackColor = true;
            this.btnSogukIcecekler.Click += new System.EventHandler(this.btnSogukIcecekler_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(658, 85);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 36);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(733, 85);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 36);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(806, 85);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 36);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(733, 125);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 36);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(658, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 36);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(806, 125);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 36);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(658, 169);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 36);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(733, 169);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 36);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(806, 167);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 36);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(733, 211);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 36);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(806, 211);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(52, 36);
            this.btnC.TabIndex = 24;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnTusSil
            // 
            this.btnTusSil.Location = new System.Drawing.Point(658, 211);
            this.btnTusSil.Name = "btnTusSil";
            this.btnTusSil.Size = new System.Drawing.Size(52, 36);
            this.btnTusSil.TabIndex = 25;
            this.btnTusSil.Text = "<--";
            this.btnTusSil.UseVisualStyleBackColor = true;
            this.btnTusSil.Click += new System.EventHandler(this.btnTusSil_Click);
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnTusSil);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSogukIcecekler);
            this.Controls.Add(this.btnSicakIcecekler);
            this.Controls.Add(this.btnFastFood);
            this.Controls.Add(this.btnTatlilar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYemekler);
            this.Controls.Add(this.btnMasayiKapat);
            this.Controls.Add(this.btnCorbalar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMasaIsmi;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblToplamTutar;
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
        private System.Windows.Forms.Button btnYemekler;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnSicakIcecekler;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnSogukIcecekler;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnTusSil;
    }
}