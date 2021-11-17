﻿using CafeAutomation.App.Models;
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
        }

        private void RaporSiparis()
        {
            RaporContext.Load();
            KapatilanSiparislerContext.Load();
            GüneGöreRaporla();
            //dgvSiparisRapor.DataSource = RaporContext.Raporlar;
            dgvSiparisRapor.ClearSelection();
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
                split = item.ToplamTutar.Split('.');

                toplam += Int32.Parse(split[0]);
            }
            lblGunToplamTutar.Text = $"{toplam.ToString()}.00₺";
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
        }
    }
}
