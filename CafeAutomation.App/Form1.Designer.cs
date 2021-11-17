
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mASALARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAHÇEKATIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zEMİNKATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tERASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASALARToolStripMenuItem,
            this.üRÜNLERToolStripMenuItem,
            this.rAPORLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mASALARToolStripMenuItem
            // 
            this.mASALARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAHÇEKATIToolStripMenuItem,
            this.zEMİNKATToolStripMenuItem,
            this.tERASToolStripMenuItem});
            this.mASALARToolStripMenuItem.Name = "mASALARToolStripMenuItem";
            this.mASALARToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mASALARToolStripMenuItem.Text = "MASALAR";
            // 
            // bAHÇEKATIToolStripMenuItem
            // 
            this.bAHÇEKATIToolStripMenuItem.Name = "bAHÇEKATIToolStripMenuItem";
            this.bAHÇEKATIToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.bAHÇEKATIToolStripMenuItem.Text = "BAHÇE KATI";
            this.bAHÇEKATIToolStripMenuItem.Click += new System.EventHandler(this.bAHÇEKATIToolStripMenuItem_Click);
            // 
            // zEMİNKATToolStripMenuItem
            // 
            this.zEMİNKATToolStripMenuItem.Name = "zEMİNKATToolStripMenuItem";
            this.zEMİNKATToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.zEMİNKATToolStripMenuItem.Text = "ZEMİN KAT";
            this.zEMİNKATToolStripMenuItem.Click += new System.EventHandler(this.zEMİNKATToolStripMenuItem_Click);
            // 
            // tERASToolStripMenuItem
            // 
            this.tERASToolStripMenuItem.Name = "tERASToolStripMenuItem";
            this.tERASToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tERASToolStripMenuItem.Text = "TERAS";
            this.tERASToolStripMenuItem.Click += new System.EventHandler(this.tERASToolStripMenuItem_Click);
            // 
            // üRÜNLERToolStripMenuItem
            // 
            this.üRÜNLERToolStripMenuItem.Name = "üRÜNLERToolStripMenuItem";
            this.üRÜNLERToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.üRÜNLERToolStripMenuItem.Text = "ÜRÜNLER";
            this.üRÜNLERToolStripMenuItem.Click += new System.EventHandler(this.üRÜNLERToolStripMenuItem_Click);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 562);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mASALARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAHÇEKATIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zEMİNKATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tERASToolStripMenuItem;
    }
}

