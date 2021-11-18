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
                    Height = 150,
                    Width = 150
                };
                masaButon.Font = new Font(masaButon.Font.FontFamily, 12);
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

            var btn = sender as Button;
            frmSiparis.lblMasaIsmi.Text = btn.Name;

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
                if (item is FlowLayoutPanel)
                {
                    item.Visible = false;
                }
                if(item is TextBox)
                {
                    item.Visible = false;
                }
                if (item is Label)
                {
                    item.Visible = false;
                }
            }
        }

        private void FrmBahceMasalar_Load(object sender, EventArgs e)
        {
            flpBahceMasalar.Controls.Clear();
            BahceMasaContext.Load();
            MasalariGetir();
            MasaKontrol();
        }

        private void MasaKontrol()
        {
            SiparisDetayContext.Load();
            int sayac = 0;
            foreach (Control item in this.flpBahceMasalar.Controls)
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
            MasaKontrol();
            txtMasaNumarasi.Text = "";
        }

        private BahceMasa silinecekBahceMasa;
        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            silinecekBahceMasa = BahceMasaContext.BahceMasalar.Find(x => x.BahceMasaNumarası == txtMasaNumarasi.Text);
            BahceMasaContext.BahceMasalar.Remove(silinecekBahceMasa);
            BahceMasaContext.Save();
            MasalariGetir();
            MasaKontrol();
            txtMasaNumarasi.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "1";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "2";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "3";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "4";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "5";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "6";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "7";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "8";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "9";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "9";
            }
        }

        private void btnTusSil_Click(object sender, EventArgs e)
        {
            string silinecekSayi = txtMasaNumarasi.Text;
            txtMasaNumarasi.Text = null;
            for (int i = 0; i < silinecekSayi.Length - 1; i++)
            {
                txtMasaNumarasi.Text += silinecekSayi[i].ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtMasaNumarasi.Text == "0" || txtMasaNumarasi.Text == null)
            {
                txtMasaNumarasi.Text = "";
            }
            else
            {
                txtMasaNumarasi.Text = txtMasaNumarasi.Text + "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtMasaNumarasi.Text = null;
        }
    }
}
