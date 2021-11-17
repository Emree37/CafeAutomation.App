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
    public partial class FrmBahceMasalar : Form
    {
        public FrmBahceMasalar()
        {
            InitializeComponent();
        }

        private void MasalariGetir()
        {
            flpBahceMasalar.Controls.Clear();
            foreach (var masa in BahceMasaContext.BahceMasalar)
            {
                Button masaButon = new Button
                {
                    Name = $"bahceMasa{masa.BahceMasaNumarası}",
                    Text = $"Bahçe Masa - {masa.BahceMasaNumarası}",
                    Height = 80,
                    Width = 80
                };
                masaButon.Click += new EventHandler(YeniButon_Click);
                flpBahceMasalar.Controls.Add(masaButon);
            }
        }

        private FrmSiparis frmSiparis;
        protected void YeniButon_Click(object sender,EventArgs e)
        {
            if(frmSiparis==null || frmSiparis.IsDisposed)
            {
                frmSiparis = new FrmSiparis();
            }
            frmSiparis.MdiParent = this;
            frmSiparis.Show();

            frmSiparis.lblMasaIsmi.Text = "bahceMasa1.Name";
            frmSiparis.SiparisleriGetir();
            frmSiparis.ToplamTutarHesaplama();
            ButonlarıGizle();
        }

        private void ButonlarıGizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Visible = false;
                }
            }
        }

        private void FrmBahceMasalar_Load(object sender, EventArgs e)
        {
            MasaKontrol();
            //------------------------------------------------
            flpBahceMasalar.Controls.Clear();
            BahceMasaContext.Load();
            MasalariGetir();
        }

        private void MasaKontrol()
        {
            SiparisDetayContext.Load();
            int sayac = 0;
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    for (int i = 0; i < SiparisDetayContext.SiparisDetaylar.Count; i++)
                    {
                        if (SiparisDetayContext.SiparisDetaylar[i].MasaIsmi == item.Name)
                        {
                            sayac++;
                        }
                    }
                    if (sayac != 0)
                    {
                        item.BackColor = Color.Red;
                    }
                    else
                    {
                        item.BackColor = Color.Green;
                    }
                    sayac = 0;
                }
            }
        }

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            BahceMasa yeniBahceMasa = new BahceMasa()
            {
                BahceMasaNumarası = txtMasaNumarasi.Text
            };
            BahceMasaContext.BahceMasalar.Add(yeniBahceMasa);
            BahceMasaContext.Save();
            MasalariGetir();
        }

        private BahceMasa silinecekBahceMasa;
        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            silinecekBahceMasa = BahceMasaContext.BahceMasalar.Find(x => x.BahceMasaNumarası == txtMasaNumarasi.Text);
            BahceMasaContext.BahceMasalar.Remove(silinecekBahceMasa);
            BahceMasaContext.Save();
            MasalariGetir();
        }
    }
}
