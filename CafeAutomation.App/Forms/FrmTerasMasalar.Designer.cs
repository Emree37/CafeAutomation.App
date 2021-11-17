
namespace CafeAutomation.App.Forms
{
    partial class FrmTerasMasalar
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
            this.txtMasaNumarasi = new System.Windows.Forms.TextBox();
            this.btnTerasMasaEkle = new System.Windows.Forms.Button();
            this.btnTerasMasaSil = new System.Windows.Forms.Button();
            this.flpTerasMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numara";
            // 
            // txtMasaNumarasi
            // 
            this.txtMasaNumarasi.Location = new System.Drawing.Point(92, 26);
            this.txtMasaNumarasi.Name = "txtMasaNumarasi";
            this.txtMasaNumarasi.Size = new System.Drawing.Size(100, 23);
            this.txtMasaNumarasi.TabIndex = 7;
            // 
            // btnTerasMasaEkle
            // 
            this.btnTerasMasaEkle.Location = new System.Drawing.Point(92, 68);
            this.btnTerasMasaEkle.Name = "btnTerasMasaEkle";
            this.btnTerasMasaEkle.Size = new System.Drawing.Size(103, 23);
            this.btnTerasMasaEkle.TabIndex = 9;
            this.btnTerasMasaEkle.Text = "Masa Ekle";
            this.btnTerasMasaEkle.UseVisualStyleBackColor = true;
            this.btnTerasMasaEkle.Click += new System.EventHandler(this.btnTerasMasaEkle_Click);
            // 
            // btnTerasMasaSil
            // 
            this.btnTerasMasaSil.Location = new System.Drawing.Point(92, 116);
            this.btnTerasMasaSil.Name = "btnTerasMasaSil";
            this.btnTerasMasaSil.Size = new System.Drawing.Size(103, 23);
            this.btnTerasMasaSil.TabIndex = 10;
            this.btnTerasMasaSil.Text = "Masayı Sil";
            this.btnTerasMasaSil.UseVisualStyleBackColor = true;
            this.btnTerasMasaSil.Click += new System.EventHandler(this.btnTerasMasaSil_Click);
            // 
            // flpTerasMasalar
            // 
            this.flpTerasMasalar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpTerasMasalar.Location = new System.Drawing.Point(283, 0);
            this.flpTerasMasalar.Name = "flpTerasMasalar";
            this.flpTerasMasalar.Size = new System.Drawing.Size(517, 450);
            this.flpTerasMasalar.TabIndex = 11;
            // 
            // FrmTerasMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpTerasMasalar);
            this.Controls.Add(this.btnTerasMasaSil);
            this.Controls.Add(this.btnTerasMasaEkle);
            this.Controls.Add(this.txtMasaNumarasi);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTerasMasalar";
            this.Text = "FrmTerasMasalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTerasMasalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasaNumarasi;
        private System.Windows.Forms.Button btnTerasMasaEkle;
        private System.Windows.Forms.Button btnTerasMasaSil;
        private System.Windows.Forms.FlowLayoutPanel flpTerasMasalar;
    }
}