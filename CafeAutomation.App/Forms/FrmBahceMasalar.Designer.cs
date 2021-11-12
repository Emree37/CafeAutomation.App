
namespace CafeAutomation.App.Forms
{
    partial class FrmBahceMasalar
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
            this.flpBahceMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.txtMasaNumarasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasaSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpBahceMasalar
            // 
            this.flpBahceMasalar.Location = new System.Drawing.Point(13, 63);
            this.flpBahceMasalar.Name = "flpBahceMasalar";
            this.flpBahceMasalar.Size = new System.Drawing.Size(775, 350);
            this.flpBahceMasalar.TabIndex = 0;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Location = new System.Drawing.Point(175, 31);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(103, 23);
            this.btnMasaEkle.TabIndex = 1;
            this.btnMasaEkle.Text = "Masa Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.btnMasaEkle_Click);
            // 
            // txtMasaNumarasi
            // 
            this.txtMasaNumarasi.Location = new System.Drawing.Point(69, 31);
            this.txtMasaNumarasi.Name = "txtMasaNumarasi";
            this.txtMasaNumarasi.Size = new System.Drawing.Size(100, 23);
            this.txtMasaNumarasi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numara";
            // 
            // btnMasaSil
            // 
            this.btnMasaSil.Location = new System.Drawing.Point(284, 31);
            this.btnMasaSil.Name = "btnMasaSil";
            this.btnMasaSil.Size = new System.Drawing.Size(103, 23);
            this.btnMasaSil.TabIndex = 4;
            this.btnMasaSil.Text = "Masayı Sil";
            this.btnMasaSil.UseVisualStyleBackColor = true;
            this.btnMasaSil.Click += new System.EventHandler(this.btnMasaSil_Click);
            // 
            // FrmBahceMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMasaSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasaNumarasi);
            this.Controls.Add(this.btnMasaEkle);
            this.Controls.Add(this.flpBahceMasalar);
            this.Name = "FrmBahceMasalar";
            this.Text = "FrmBahceMasalar";
            this.Load += new System.EventHandler(this.FrmBahceMasalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBahceMasalar;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.TextBox txtMasaNumarasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasaSil;
    }
}