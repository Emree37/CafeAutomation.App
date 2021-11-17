
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
            this.dgvSiparisRapor = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetayRapor = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSecilenGunIsmi = new System.Windows.Forms.Label();
            this.lblGunToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetayRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisRapor
            // 
            this.dgvSiparisRapor.AllowUserToAddRows = false;
            this.dgvSiparisRapor.AllowUserToDeleteRows = false;
            this.dgvSiparisRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisRapor.Location = new System.Drawing.Point(13, 22);
            this.dgvSiparisRapor.Name = "dgvSiparisRapor";
            this.dgvSiparisRapor.ReadOnly = true;
            this.dgvSiparisRapor.RowTemplate.Height = 25;
            this.dgvSiparisRapor.Size = new System.Drawing.Size(368, 230);
            this.dgvSiparisRapor.TabIndex = 0;
            this.dgvSiparisRapor.SelectionChanged += new System.EventHandler(this.dgvSiparisRapor_SelectionChanged);
            // 
            // dgvSiparisDetayRapor
            // 
            this.dgvSiparisDetayRapor.AllowUserToAddRows = false;
            this.dgvSiparisDetayRapor.AllowUserToDeleteRows = false;
            this.dgvSiparisDetayRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetayRapor.Location = new System.Drawing.Point(387, 22);
            this.dgvSiparisDetayRapor.Name = "dgvSiparisDetayRapor";
            this.dgvSiparisDetayRapor.ReadOnly = true;
            this.dgvSiparisDetayRapor.RowTemplate.Height = 25;
            this.dgvSiparisDetayRapor.Size = new System.Drawing.Size(386, 230);
            this.dgvSiparisDetayRapor.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblSecilenGunIsmi
            // 
            this.lblSecilenGunIsmi.AutoSize = true;
            this.lblSecilenGunIsmi.Location = new System.Drawing.Point(238, 294);
            this.lblSecilenGunIsmi.Name = "lblSecilenGunIsmi";
            this.lblSecilenGunIsmi.Size = new System.Drawing.Size(38, 15);
            this.lblSecilenGunIsmi.TabIndex = 3;
            this.lblSecilenGunIsmi.Text = "label1";
            // 
            // lblGunToplamTutar
            // 
            this.lblGunToplamTutar.AutoSize = true;
            this.lblGunToplamTutar.Location = new System.Drawing.Point(418, 287);
            this.lblGunToplamTutar.Name = "lblGunToplamTutar";
            this.lblGunToplamTutar.Size = new System.Drawing.Size(38, 15);
            this.lblGunToplamTutar.TabIndex = 4;
            this.lblGunToplamTutar.Text = "label2";
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}