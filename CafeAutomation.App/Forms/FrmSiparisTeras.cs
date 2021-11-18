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
    public partial class FrmSiparisTeras : Form
    {
        public FrmSiparisTeras()
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
            FrmTerasMasalar parent = this.MdiParent as FrmTerasMasalar;
            if (sayac != 0)
            {

                foreach (Control item in parent.flpTerasMasalar.Controls)
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
                foreach (Control item in parent.flpTerasMasalar.Controls)
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

        private void btnCorbalar_Click(object sender, EventArgs e)
        {
            cmbUrunler.Text = " ";
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "Çorbalar")
                {
                    cmbUrunler.Items.Add(urun);
                }

            }
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            cmbUrunler.Text = " ";
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
            string[] toplamTutar = lblToplamTutar.Text.Split('.');
            Rapor rapor = new Rapor()
            {
                MasaIsmi = lblMasaIsmi.Text,
                //Tarih = DateTime.Now.ToShortDateString(),
                TarihGun = DateTime.Now.ToString("MM/dd/yyyy"),
                TarihSaat = DateTime.Now.ToString("HH:mm:ss"),
                Tarih = DateTime.Now,
                ToplamTutar = Int32.Parse(toplamTutar[0])
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
                        TarihSaat = DateTime.Now.ToString("HH:mm:ss"),
                        Tarih = DateTime.Now
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
            using (System.IO.StreamWriter file =
         new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/yazdir{lblMasaIsmi.Text}.txt", false))
            {
                file.WriteLine("   ----------  CAFE AUTOMATİON  ----------   ");
                file.WriteLine("MASA İSMİ: " + lblMasaIsmi.Text);
                file.WriteLine("--- Masa Detay : ---");
                file.WriteLine(" |     Ürün    |    Fiyat    |     Adet   ");
                string lines = "";

                for (int row = 0; row < SiparisDetayContext.SiparisDetaylar.Count; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {

                        lines = lines + " | " + dgvListe.Rows[row].Cells[col].Value.ToString();
                        if (col == 2)
                        {

                            file.WriteLine(lines);
                            lines = "";
                        }
                    }

                }
                file.WriteLine(" ------------------------");
                file.WriteLine(" Toplam :" + lblToplamTutar.Text.ToString());

            }


            var pi = new ProcessStartInfo("yazdir.txt");
            pi.UseShellExecute = true;
            pi.Verb = "print";
            //var process = System.Diagnostics.Process.Start(pi);

            MessageBox.Show("YAZDIRILIYOR...");
        }

        private void FrmSiparisTeras_FormClosed(object sender, FormClosedEventArgs e)
        {
            ButonlarıGöster();
            dgvListe.ClearSelection();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
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

        private void FrmSiparisTeras_Load(object sender, EventArgs e)
        {
            UrunContext.Load();
            GridAyari();
            ToplamTutarHesaplama();
            dgvListe.ClearSelection();
            MasaKontrol();
            cmbUrunler.SelectedItem = null;
            cmbUrunler.SelectedText = "--Seçiniz--";
        }

        private void btnYemekler_Click(object sender, EventArgs e)
        {
            cmbUrunler.Text = " ";
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "Yemekler")
                {
                    cmbUrunler.Items.Add(urun);
                }
            }
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            cmbUrunler.Text = " ";
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "Tatlılar")
                {
                    cmbUrunler.Items.Add(urun);
                }
            }
        }

        private void btnSicakIcecekler_Click(object sender, EventArgs e)
        {
            cmbUrunler.Text = " ";
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "Sıcak İçecekler")
                {
                    cmbUrunler.Items.Add(urun);
                }
            }
        }

        private void btnSogukIcecekler_Click(object sender, EventArgs e)
        {
            cmbUrunler.Text = " ";
            cmbUrunler.Items.Clear();
            foreach (var urun in UrunContext.Urunler)
            {
                if (urun.Kategori == "Soğuk İçecekler")
                {
                    cmbUrunler.Items.Add(urun);
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "1";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "2";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "3";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "4";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "5";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "6";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "7";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "8";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "9";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "9";
            }
        }

        private void btnTusSil_Click(object sender, EventArgs e)
        {
            string silinecekSayi = txtAdet.Text;
            txtAdet.Text = null;
            for (int i = 0; i < silinecekSayi.Length - 1; i++)
            {
                txtAdet.Text += silinecekSayi[i].ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "0" || txtAdet.Text == null)
            {
                txtAdet.Text = "";
            }
            else
            {
                txtAdet.Text = txtAdet.Text + "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAdet.Text = null;
        }
    }
}
