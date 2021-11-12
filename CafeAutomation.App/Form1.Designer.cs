
namespace CafeAutomation.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMasalar = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackColor = System.Drawing.Color.Transparent;
            this.btnMasalar.FlatAppearance.BorderSize = 0;
            this.btnMasalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasalar.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMasalar.Location = new System.Drawing.Point(509, 119);
            this.btnMasalar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(166, 64);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.TabStop = false;
            this.btnMasalar.Text = "MASALAR";
            this.btnMasalar.UseVisualStyleBackColor = false;
            this.btnMasalar.MouseEnter += new System.EventHandler(this.btnMasalar_MouseEnter);
            this.btnMasalar.MouseLeave += new System.EventHandler(this.btnMasalar_MouseLeave);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.Transparent;
            this.btnRaporlar.FlatAppearance.BorderSize = 0;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaporlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaporlar.Location = new System.Drawing.Point(509, 258);
            this.btnRaporlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(166, 64);
            this.btnRaporlar.TabIndex = 1;
            this.btnRaporlar.TabStop = false;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.MouseEnter += new System.EventHandler(this.btnRaporlar_MouseEnter);
            this.btnRaporlar.MouseLeave += new System.EventHandler(this.btnRaporlar_MouseLeave);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(509, 351);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(166, 57);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunler.FlatAppearance.BorderSize = 0;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunler.Location = new System.Drawing.Point(509, 193);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(166, 64);
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.TabStop = false;
            this.btnUrunler.Text = "ÜRÜNLER";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 562);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnMasalar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUrunler;
    }
}

