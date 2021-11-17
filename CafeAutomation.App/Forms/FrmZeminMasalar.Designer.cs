
namespace CafeAutomation.App.Forms
{
    partial class FrmZeminMasalar
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpZeminMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMasaNumarasi = new System.Windows.Forms.TextBox();
            this.btnZeminMasaSil = new System.Windows.Forms.Button();
            this.btnZeminMasaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numara";
            // 
            // flpZeminMasalar
            // 
            this.flpZeminMasalar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpZeminMasalar.Location = new System.Drawing.Point(190, 0);
            this.flpZeminMasalar.Name = "flpZeminMasalar";
            this.flpZeminMasalar.Size = new System.Drawing.Size(610, 450);
            this.flpZeminMasalar.TabIndex = 5;
            // 
            // txtMasaNumarasi
            // 
            this.txtMasaNumarasi.Location = new System.Drawing.Point(69, 18);
            this.txtMasaNumarasi.Name = "txtMasaNumarasi";
            this.txtMasaNumarasi.Size = new System.Drawing.Size(100, 23);
            this.txtMasaNumarasi.TabIndex = 6;
            // 
            // btnZeminMasaSil
            // 
            this.btnZeminMasaSil.Location = new System.Drawing.Point(69, 88);
            this.btnZeminMasaSil.Name = "btnZeminMasaSil";
            this.btnZeminMasaSil.Size = new System.Drawing.Size(103, 23);
            this.btnZeminMasaSil.TabIndex = 7;
            this.btnZeminMasaSil.Text = "Masayı Sil";
            this.btnZeminMasaSil.UseVisualStyleBackColor = true;
            this.btnZeminMasaSil.Click += new System.EventHandler(this.btnZeminMasaSil_Click);
            // 
            // btnZeminMasaEkle
            // 
            this.btnZeminMasaEkle.Location = new System.Drawing.Point(69, 50);
            this.btnZeminMasaEkle.Name = "btnZeminMasaEkle";
            this.btnZeminMasaEkle.Size = new System.Drawing.Size(103, 23);
            this.btnZeminMasaEkle.TabIndex = 8;
            this.btnZeminMasaEkle.Text = "Masa Ekle";
            this.btnZeminMasaEkle.UseVisualStyleBackColor = true;
            this.btnZeminMasaEkle.Click += new System.EventHandler(this.btnZeminMasaEkle_Click);
            // 
            // FrmZeminMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZeminMasaEkle);
            this.Controls.Add(this.btnZeminMasaSil);
            this.Controls.Add(this.txtMasaNumarasi);
            this.Controls.Add(this.flpZeminMasalar);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZeminMasalar";
            this.Text = "FrmZeminMasalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmZeminMasalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpZeminMasalar;
        private System.Windows.Forms.TextBox txtMasaNumarasi;
        private System.Windows.Forms.Button btnZeminMasaSil;
        private System.Windows.Forms.Button btnZeminMasaEkle;
    }
}