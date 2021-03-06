
namespace CafeAutomation.App.Forms
{
    partial class FrmRapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            this.dgvSiparisRapor = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetayRapor = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSecilenGunIsmi = new System.Windows.Forms.Label();
            this.lblGunToplamTutar = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetayRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisRapor
            // 
            this.dgvSiparisRapor.AllowUserToAddRows = false;
            this.dgvSiparisRapor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSiparisRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSiparisRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisRapor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSiparisRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Format = "50,50,50";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiparisRapor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSiparisRapor.Location = new System.Drawing.Point(12, 65);
            this.dgvSiparisRapor.MultiSelect = false;
            this.dgvSiparisRapor.Name = "dgvSiparisRapor";
            this.dgvSiparisRapor.ReadOnly = true;
            this.dgvSiparisRapor.RowTemplate.Height = 25;
            this.dgvSiparisRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisRapor.Size = new System.Drawing.Size(650, 270);
            this.dgvSiparisRapor.TabIndex = 0;
            this.dgvSiparisRapor.SelectionChanged += new System.EventHandler(this.dgvSiparisRapor_SelectionChanged);
            // 
            // dgvSiparisDetayRapor
            // 
            this.dgvSiparisDetayRapor.AllowUserToAddRows = false;
            this.dgvSiparisDetayRapor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSiparisDetayRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSiparisDetayRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetayRapor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSiparisDetayRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiparisDetayRapor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSiparisDetayRapor.Location = new System.Drawing.Point(12, 350);
            this.dgvSiparisDetayRapor.MultiSelect = false;
            this.dgvSiparisDetayRapor.Name = "dgvSiparisDetayRapor";
            this.dgvSiparisDetayRapor.ReadOnly = true;
            this.dgvSiparisDetayRapor.RowTemplate.Height = 25;
            this.dgvSiparisDetayRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetayRapor.Size = new System.Drawing.Size(650, 300);
            this.dgvSiparisDetayRapor.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblSecilenGunIsmi
            // 
            this.lblSecilenGunIsmi.AutoSize = true;
            this.lblSecilenGunIsmi.BackColor = System.Drawing.Color.Transparent;
            this.lblSecilenGunIsmi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenGunIsmi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSecilenGunIsmi.Location = new System.Drawing.Point(267, 9);
            this.lblSecilenGunIsmi.Name = "lblSecilenGunIsmi";
            this.lblSecilenGunIsmi.Size = new System.Drawing.Size(65, 28);
            this.lblSecilenGunIsmi.TabIndex = 3;
            this.lblSecilenGunIsmi.Text = "label1";
            // 
            // lblGunToplamTutar
            // 
            this.lblGunToplamTutar.AutoSize = true;
            this.lblGunToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblGunToplamTutar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGunToplamTutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGunToplamTutar.Location = new System.Drawing.Point(597, 9);
            this.lblGunToplamTutar.Name = "lblGunToplamTutar";
            this.lblGunToplamTutar.Size = new System.Drawing.Size(65, 28);
            this.lblGunToplamTutar.TabIndex = 4;
            this.lblGunToplamTutar.Text = "label2";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeriDon.BackgroundImage")));
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGeriDon.Location = new System.Drawing.Point(1755, 884);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(97, 66);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(763, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOPLAM CİRO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(929, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1402, 780);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblGunToplamTutar);
            this.Controls.Add(this.lblSecilenGunIsmi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvSiparisDetayRapor);
            this.Controls.Add(this.dgvSiparisRapor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRapor_FormClosed);
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetayRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisRapor;
        private System.Windows.Forms.DataGridView dgvSiparisDetayRapor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSecilenGunIsmi;
        private System.Windows.Forms.Label lblGunToplamTutar;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}