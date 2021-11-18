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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
            DatagridviewSetting(dgvSiparisRapor);
            DatagridviewSetting(dgvSiparisDetayRapor);
        }

        private void FrmRapor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ButonlarıGöster();
        }

        //private void ButonlarıGöster()
        //{
        //    foreach (Control item in this.MdiParent.Controls)
        //    {
        //        if (item is Button)
        //        {
        //            item.Visible = true;
        //        }
        //    }
        //}

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            RaporSiparis();
            AyaGöreRaporlar();
        }

        public void DatagridviewSetting(DataGridView datagridview)
        {
            datagridview.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            datagridview.DefaultCellStyle.SelectionBackColor = Color.Blue;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RaporSiparis()
        {
            RaporContext.Load();
            KapatilanSiparislerContext.Load();
            GüneGöreRaporla();
            //dgvSiparisRapor.ClearSelection();
        }

        private List<Rapor> GünRaporu = new List<Rapor>();
        private int toplam = 0;
        private string[] split;

        private void GüneGöreRaporla()
        {
            lblSecilenGunIsmi.Text = $"{dateTimePicker1.Value.ToString("MM/dd/yyyy")} Günü Toplam Cirosu";
            RaporContext.Load();
            GünRaporu = RaporContext.Raporlar.ToList();

            GünRaporu = GünRaporu.Where(x => x.TarihGun == dateTimePicker1.Value.ToString("MM/dd/yyyy")).ToList();
            dgvSiparisRapor.DataSource = GünRaporu;

            toplam = 0;
            foreach (var item in GünRaporu)
            {
                toplam += item.ToplamTutar;
            }
            lblGunToplamTutar.Text = $"{toplam.ToString()}.00₺";
        }

        private List<Rapor> AyRaporu = new List<Rapor>();
        DateTimePicker dtp = new DateTimePicker();
        private void AyaGöreRaporlar()
        {
            RaporContext.Load();
            AyRaporu = RaporContext.Raporlar.ToList();
            int toplamCiro = 0;
            for (DateTime a = DateTime.Now.AddDays(-2); a <= dtp.Value.AddDays(30); a = a.AddDays(1))
            {
                var seciliGunler = RaporContext.Raporlar.Where(x => x.Tarih.Day == a.Day);
                foreach (var item in seciliGunler)
                {
                    toplamCiro += (item.ToplamTutar);
                }
            }
            label2.Text = toplamCiro.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GüneGöreRaporla();
        }

        private List<KapatilanSiparisler> KapatilanSiparisler = new List<KapatilanSiparisler>();

        private void dgvSiparisRapor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisRapor.SelectedRows.Count == 0)
            {
                return;
            }

            var selected = dgvSiparisRapor.SelectedRows[0];
            KapatilanSiparislerContext.Load();
            KapatilanSiparisler = KapatilanSiparislerContext.KapatilanSiparisler.ToList();
            KapatilanSiparisler = KapatilanSiparisler.Where(x => x.MasaIsmi == selected.Cells[0].Value.ToString() &&
            x.TarihGun == selected.Cells[1].Value.ToString() &&
            x.TarihSaat == selected.Cells[2].Value.ToString()).ToList();
            dgvSiparisDetayRapor.DataSource = KapatilanSiparisler;
            GridAyari();
        }

        private void GridAyari()
        {
            dgvSiparisDetayRapor.Columns[0].HeaderText = "ÜRÜN ADI";
            dgvSiparisDetayRapor.Columns[1].HeaderText = "FİYAT";
            dgvSiparisDetayRapor.Columns[2].HeaderText = "ADET";
            dgvSiparisDetayRapor.Columns[3].HeaderText = "TUTAR(₺)";
            dgvSiparisDetayRapor.Columns["MasaIsmi"].Visible = false;
            dgvSiparisDetayRapor.Columns["TarihGun"].Visible = false;
            dgvSiparisDetayRapor.Columns["TarihSaat"].Visible = false;
            dgvSiparisDetayRapor.Columns["Tarih"].Visible = false;

            dgvSiparisRapor.Columns[0].HeaderText = "MASA İSMİ";
            dgvSiparisRapor.Columns[1].HeaderText = "GÜN";
            dgvSiparisRapor.Columns[2].HeaderText = "SAAT";
            dgvSiparisRapor.Columns[3].HeaderText = "TOPLAM TUTAR";
            dgvSiparisRapor.Columns["Tarih"].Visible = false;
            dgvSiparisRapor.Columns["ToplamTutar"].Visible = false;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
