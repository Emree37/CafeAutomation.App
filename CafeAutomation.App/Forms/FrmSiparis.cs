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
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        private List<SiparisDetay> SiparisDetaylarKategori = new List<SiparisDetay>();
        public void SiparisleriGetir()
        {

            SiparisDetayContext.Load();
            SiparisDetaylarKategori = SiparisDetayContext.SiparisDetaylar.ToList();
            SiparisDetaylarKategori = SiparisDetaylarKategori.Where(x => x.MasaIsmi == $"{lblMasaIsmi.Text}").ToList();
            dgvListe.DataSource = SiparisDetaylarKategori;
            dgvListe.ClearSelection();
            MasaKontrol();
        }

        public void ToplamTutarHesaplama()
        {
            int toplamTutar = 0;
            for (int i = 0; i < dgvListe.Rows.Count; ++i)
            {
                toplamTutar += (Convert.ToInt32(dgvListe.Rows[i].Cells[1].Value) * Convert.ToInt32(dgvListe.Rows[i].Cells[2].Value));
            }
            lblToplamTutar.Text = $"{toplamTutar.ToString()}.00 ₺";
        }

        private string seciliMasa;
        public void MasaKontrol()
        {
            seciliMasa = lblMasaIsmi.Text;
            int sayac = 0;
            for (int i = 0; i < SiparisDetayContext.SiparisDetaylar.Count; i++)
            {
                if (SiparisDetayContext.SiparisDetaylar[i].MasaIsmi == seciliMasa)
                {
                    sayac++;
                }
            }
            if (sayac != 0)
            {
                foreach (Control item in this.MdiParent.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == seciliMasa)
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                foreach (Control item in this.MdiParent.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == seciliMasa)
                        {
                            item.BackColor = Color.Green;
                        }
                    }
                }
            }



        }
    }
}
