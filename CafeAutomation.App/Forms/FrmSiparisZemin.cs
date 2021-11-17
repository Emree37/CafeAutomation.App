using CafeAutomation.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.App.Forms
{
    public partial class FrmSiparisZemin : Form
    {
        public FrmSiparisZemin()
        {
            InitializeComponent();
        }

        private void GridAyari()
        {
            dgvListe.ReadOnly = true;

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
            FrmZeminMasalar parent = this.MdiParent as FrmZeminMasalar;
            if (sayac != 0)
            {

                foreach (Control item in parent.flpZeminMasalar.Controls)
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
                foreach (Control item in parent.flpZeminMasalar.Controls)
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

        private void ButonlarıGöster()
        {
            foreach (Control item in this.MdiParent.Controls)
            {
                if (item is Button)
                {
                    item.Visible = true;
                }
                if (item is FlowLayoutPanel)
                {
                    item.Visible = true;
                }
                if (item is TextBox)
                {
                    item.Visible = true;
                }
                if (item is Label)
                {
                    item.Visible = true;
                }
            }
        }

        
        

        private void btnCorbalar_Click_1(object sender, EventArgs e)
        {
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "Çorbalar")
                {
                    cmbUrunler.Items.Add(urun);
                }

            }
        }

        private void btnFastFood_Click_1(object sender, EventArgs e)
        {
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "FastFood")
                {
                    cmbUrunler.Items.Add(urun);
                }
            }
        }

        private void btnMasayiKapat_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor()
            {
                MasaIsmi = lblMasaIsmi.Text,
                //Tarih = DateTime.Now.ToShortDateString(),
                TarihGun = DateTime.Now.ToString("MM/dd/yyyy"),
                TarihSaat = DateTime.Now.ToString("HH:mm:ss"),
                ToplamTutar = lblToplamTutar.Text
            };
            RaporContext.Raporlar.Add(rapor);
            RaporContext.Save();

            seciliMasa = lblMasaIsmi.Text;
            for (int i = 0; i < SiparisDetayContext.SiparisDetaylar.Count; i++)
            {
                if (SiparisDetayContext.SiparisDetaylar[i].MasaIsmi == seciliMasa)
                {
                    KapatilanSiparisler kapatilanSiparisler = new KapatilanSiparisler()
                    {
                        UrunAdi = SiparisDetayContext.SiparisDetaylar[i].UrunAdi,
                        Fiyat = SiparisDetayContext.SiparisDetaylar[i].Fiyat,
                        Adet = SiparisDetayContext.SiparisDetaylar[i].Adet,
                        TutarTL = SiparisDetayContext.SiparisDetaylar[i].TutarTL,
                        MasaIsmi = SiparisDetayContext.SiparisDetaylar[i].MasaIsmi,
                        TarihGun = DateTime.Now.ToString("MM/dd/yyyy"),
                        TarihSaat = DateTime.Now.ToString("HH:mm:ss")
                    };
                    KapatilanSiparislerContext.KapatilanSiparisler.Add(kapatilanSiparisler);
                    KapatilanSiparislerContext.Save();

                    SiparisDetayContext.SiparisDetaylar.Remove(SiparisDetayContext.SiparisDetaylar[i]);
                    SiparisDetayContext.Save();

                    i--;
                }
            }
            MasaKontrol();
            Close();
        }

        private void btnAdisyon_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor()
            {
                MasaIsmi = lblMasaIsmi.Text,
                //Tarih = DateTime.Now.ToShortDateString(),
                TarihGun = DateTime.Now.ToString("MM/dd/yyyy"),
                TarihSaat = DateTime.Now.ToString("HH:mm:ss"),
                ToplamTutar = lblToplamTutar.Text
            };
            RaporContext.Raporlar.Add(rapor);
            RaporContext.Save();

            seciliMasa = lblMasaIsmi.Text;
            for (int i = 0; i < SiparisDetayContext.SiparisDetaylar.Count; i++)
            {
                if (SiparisDetayContext.SiparisDetaylar[i].MasaIsmi == seciliMasa)
                {
                    KapatilanSiparisler kapatilanSiparisler = new KapatilanSiparisler()
                    {
                        UrunAdi = SiparisDetayContext.SiparisDetaylar[i].UrunAdi,
                        Fiyat = SiparisDetayContext.SiparisDetaylar[i].Fiyat,
                        Adet = SiparisDetayContext.SiparisDetaylar[i].Adet,
                        TutarTL = SiparisDetayContext.SiparisDetaylar[i].TutarTL,
                        MasaIsmi = SiparisDetayContext.SiparisDetaylar[i].MasaIsmi,
                        TarihGun = DateTime.Now.ToString("MM/dd/yyyy"),
                        TarihSaat = DateTime.Now.ToString("HH:mm:ss")
                    };
                    KapatilanSiparislerContext.KapatilanSiparisler.Add(kapatilanSiparisler);
                    KapatilanSiparislerContext.Save();

                    SiparisDetayContext.SiparisDetaylar.Remove(SiparisDetayContext.SiparisDetaylar[i]);
                    SiparisDetayContext.Save();

                    i--;
                }
            }
            MasaKontrol();
            Close();
        }

        private void FrmSiparisZemin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ButonlarıGöster();
            dgvListe.ClearSelection();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            MasaKontrol();
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            seciliMasa = lblMasaIsmi.Text;
            for (int i = 0; i < SiparisDetayContext.SiparisDetaylar.Count; i++)
            {
                if (SiparisDetayContext.SiparisDetaylar[i].MasaIsmi == seciliMasa)
                {
                    SiparisDetayContext.SiparisDetaylar.Remove(SiparisDetayContext.SiparisDetaylar[i]);
                    SiparisDetayContext.Save();
                    i--;
                }
            }
            MasaKontrol();
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var selected = dgvListe.SelectedRows[0];
            seciliMasa = selected.Cells[4].Value.ToString();
            var secili = SiparisDetayContext.SiparisDetaylar.Where(x => x.MasaIsmi == seciliMasa).ToList()[selected.Index];
            SiparisDetayContext.SiparisDetaylar.Remove(secili);
            SiparisDetayContext.Save();
            SiparisleriGetir();
            ToplamTutarHesaplama();
            MasaKontrol();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun seciliUrun = (Urun)cmbUrunler.SelectedItem;
            SiparisDetay siparisDetay = new SiparisDetay
            {
                UrunAdi = seciliUrun.UrunAdi,
                Fiyat = seciliUrun.Fiyat,
                Adet = txtAdet.Text,
                TutarTL = (Int32.Parse(seciliUrun.Fiyat) * Int32.Parse(txtAdet.Text)).ToString(),
                MasaIsmi = lblMasaIsmi.Text
            };
            SiparisDetayContext.SiparisDetaylar.Add(siparisDetay);
            SiparisDetayContext.Save();
            SiparisleriGetir();

            dgvListe.ClearSelection();
            ToplamTutarHesaplama();
            MasaKontrol();
        }

        private void FrmSiparisZemin_Load(object sender, EventArgs e)
        {
            UrunContext.Load();
            GridAyari();
            ToplamTutarHesaplama();
            dgvListe.ClearSelection();
            MasaKontrol();
        }
    }
}
