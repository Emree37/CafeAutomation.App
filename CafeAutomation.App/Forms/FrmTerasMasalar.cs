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
    public partial class FrmTerasMasalar : Form
    {
        public FrmTerasMasalar()
        {
            InitializeComponent();
        }

        private void MasalariGetir()
        {
            flpTerasMasalar.Controls.Clear();
            foreach (var masa in TerasMasaContext.TerasMasalar)
            {
                Button masaButon = new Button
                {
                    Name = $"terasMasa{masa.TerasMasaNumarası}",
                    Text = $"Teras Masa - {masa.TerasMasaNumarası}",
                    Height = 150,
                    Width = 150
                };
                masaButon.Font = new Font(masaButon.Font.FontFamily, 12);
                masaButon.Click += new EventHandler(YeniButon_Click);
                flpTerasMasalar.Controls.Add(masaButon);
            }
        }

        private FrmSiparisTeras frmSiparisTeras;
        protected void YeniButon_Click(object sender, EventArgs e)
        {
            if (frmSiparisTeras == null || frmSiparisTeras.IsDisposed)
            {
                frmSiparisTeras = new FrmSiparisTeras();
            }
            frmSiparisTeras.MdiParent = this;
            frmSiparisTeras.Show();

            var btn = sender as Button;
            frmSiparisTeras.lblMasaIsmi.Text = btn.Name;

            frmSiparisTeras.SiparisleriGetir();
            frmSiparisTeras.ToplamTutarHesaplama();

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
                if (item is FlowLayoutPanel)
                {
                    item.Visible = false;
                }
                if (item is TextBox)
                {
                    item.Visible = false;
                }
                if (item is Label)
                {
                    item.Visible = false;
                }
            }
        }

        private void FrmTerasMasalar_Load(object sender, EventArgs e)
        {
            flpTerasMasalar.Controls.Clear();
            TerasMasaContext.Load();
            MasalariGetir();
            MasaKontrol();
        }

        private void MasaKontrol()
        {
            SiparisDetayContext.Load();
            int sayac = 0;
            foreach (Control item in this.flpTerasMasalar.Controls)
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

        private void btnTerasMasaEkle_Click(object sender, EventArgs e)
        {
            TerasMasa yeniTerasMasa = new TerasMasa()
            {
                TerasMasaNumarası = txtMasaNumarasi.Text
            };
            TerasMasaContext.TerasMasalar.Add(yeniTerasMasa);
            TerasMasaContext.Save();
            MasalariGetir();
            MasaKontrol();
        }

        private TerasMasa silinecekTerasMasa;
        private void btnTerasMasaSil_Click(object sender, EventArgs e)
        {
            silinecekTerasMasa = TerasMasaContext.TerasMasalar.Find(x => x.TerasMasaNumarası == txtMasaNumarasi.Text);
            TerasMasaContext.TerasMasalar.Remove(silinecekTerasMasa);
            TerasMasaContext.Save();
            MasalariGetir();
            MasaKontrol();
        }
    }
}
