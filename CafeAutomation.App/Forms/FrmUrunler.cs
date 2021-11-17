using CafeAutomation.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.App.Forms
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void ListeyiDoldur()
        {
            lstUrunler.Items.Clear();
            foreach (Urun urun in UrunContext.Urunler)
            {
                lstUrunler.Items.Add(urun);
            }
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunContext.Load();
            ListeyiDoldur();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun()
            {
                UrunAdi = txtUrunAd.Text,
                Fiyat = txtFiyat.Text,
                Kategori = txtKategori.Text
            };
            UrunContext.Urunler.Add(yeniUrun);
            ListeyiDoldur();
            UrunContext.Save();
        }

        private Urun seciliUrun;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            seciliUrun = lstUrunler.SelectedItem as Urun;
            txtUrunAd.Text = seciliUrun.UrunAdi;
            txtFiyat.Text = seciliUrun.Fiyat;
            txtKategori.Text = seciliUrun.Kategori;
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliUrun.UrunAdi = txtUrunAd.Text;
            seciliUrun.Fiyat = txtFiyat.Text;
            seciliUrun.Kategori = txtKategori.Text;
            ListeyiDoldur();
            UrunContext.Save();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            seciliUrun = lstUrunler.SelectedItem as Urun;
            UrunContext.Urunler.Remove(seciliUrun);
            ListeyiDoldur();
            UrunContext.Save();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
