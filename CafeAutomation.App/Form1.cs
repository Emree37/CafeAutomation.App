using CafeAutomation.App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMasalar_MouseEnter(object sender, EventArgs e)
        {
            btnMasalar.UseVisualStyleBackColor = false;
            btnMasalar.BackColor = Color.DarkGray;
        }

        private void btnMasalar_MouseLeave(object sender, EventArgs e)
        {
            btnMasalar.UseVisualStyleBackColor = true;
            btnMasalar.BackColor = Color.Transparent;
        }

        private void btnRaporlar_MouseEnter(object sender, EventArgs e)
        {
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.BackColor = Color.DarkGray;
        }

        private void btnRaporlar_MouseLeave(object sender, EventArgs e)
        {
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.BackColor = Color.Transparent;
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.BackColor = Color.Red;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.BackColor = Color.Transparent;
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunler frmUrunler = new FrmUrunler();
            frmUrunler.Show();
            this.Hide();
        }
    }
}
