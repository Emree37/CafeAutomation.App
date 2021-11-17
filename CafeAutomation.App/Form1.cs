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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private FrmUrunler frmUrunler;
        private void üRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUrunler == null || frmUrunler.IsDisposed)
                frmUrunler = new FrmUrunler();
            //frmUrunler.MdiParent = this;
            frmUrunler.Show();
        }

        private FrmRapor frmRapor;
        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRapor == null || frmRapor.IsDisposed)
                frmRapor = new FrmRapor();
            //frmUrunler.MdiParent = this;
            frmRapor.Show();
        }

        private FrmBahceMasalar frmBahceMasalar;
        private void bAHÇEKATIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBahceMasalar == null || frmBahceMasalar.IsDisposed)
                frmBahceMasalar = new FrmBahceMasalar();
            frmBahceMasalar.Show();
        }

        private FrmZeminMasalar frmZeminMasalar;
        private void zEMİNKATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmZeminMasalar == null || frmZeminMasalar.IsDisposed)
                frmZeminMasalar = new FrmZeminMasalar();
            frmZeminMasalar.Show();
        }

        private FrmTerasMasalar frmTerasMasalar;
        private void tERASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTerasMasalar == null || frmTerasMasalar.IsDisposed)
                frmTerasMasalar = new FrmTerasMasalar();
            frmTerasMasalar.Show();
        }

        
    }
}
