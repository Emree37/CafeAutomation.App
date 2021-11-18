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
    public partial class FrmZeminMasalar : Form
    {
        public FrmZeminMasalar()
        {
            InitializeComponent();
        }

        private void MasalariGetir()
        {
            flpZeminMasalar.Controls.Clear();
            foreach (var masa in ZeminMasaContext.ZeminMasalar)
            {
                Button masaButon = new Button
                {
                    Name = $"zeminMasa{masa.ZeminMasaNumarası}",
                    Text = $"Zemin Masa - {masa.ZeminMasaNumarası}",
                    Height = 150,
                    Width = 150
                };
                masaButon.Font = new Font(masaButon.Font.FontFamily, 12);
                masaButon.Click += new EventHandler(YeniButon_Click);
                flpZeminMasalar.Controls.Add(masaButon);
            }
        }

        private FrmSiparisZemin frmSiparisZemin;
        protected void YeniButon_Click(object sender, EventArgs e)
        {
            if (frmSiparisZemin == null || frmSiparisZemin.IsDisposed)
            {
                frmSiparisZemin = new FrmSiparisZemin();
            }
            frmSiparisZemin.MdiParent = this;
            frmSiparisZemin.Show();

            var btn = sender as Button;
            frmSiparisZemin.lblMasaIsmi.Text = btn.Name;

            frmSiparisZemin.SiparisleriGetir();
            frmSiparisZemin.ToplamTutarHesaplama();
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

        private void FrmZeminMasalar_Load(object sender, EventArgs e)
        {
            flpZeminMasalar.Controls.Clear();
            ZeminMasaContext.Load();
            MasalariGetir();
            MasaKontrol();
        }

        private void MasaKontrol()
        {
            SiparisDetayContext.Load();
            int sayac = 0;
            foreach (Control item in this.flpZeminMasalar.Controls)
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

        private void btnZeminMasaEkle_Click(object sender, EventArgs e)
        {
            ZeminMasa yeniZeminMasa = new ZeminMasa()
            {
                ZeminMasaNumarası = txtMasaNumarasi.Text
            };
            ZeminMasaContext.ZeminMasalar.Add(yeniZeminMasa);
            ZeminMasaContext.Save();
            MasalariGetir();
            MasaKontrol();
        }

        private ZeminMasa silinecekZeminMasa;
        private void btnZeminMasaSil_Click(object sender, EventArgs e)
        {
            silinecekZeminMasa = ZeminMasaContext.ZeminMasalar.Find(x => x.ZeminMasaNumarası == txtMasaNumarasi.Text);
            ZeminMasaContext.ZeminMasalar.Remove(silinecekZeminMasa);
            ZeminMasaContext.Save();
            MasalariGetir();
            MasaKontrol();
        }
    }
}
