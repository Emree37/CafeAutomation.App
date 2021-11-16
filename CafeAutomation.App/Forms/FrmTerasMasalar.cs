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
                    Height = 80,
                    Width = 80
                };
                masaButon.Click += new EventHandler(YeniButon_Click);
                flpTerasMasalar.Controls.Add(masaButon);
            }
        }

        private void YeniButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Heyyyy");
        }

        private void FrmTerasMasalar_Load(object sender, EventArgs e)
        {
            //MasaOlustur();
            flpTerasMasalar.Controls.Clear();
            TerasMasaContext.Load();
            MasalariGetir();
        }

        private TerasMasa silinecekTerasMasa;
        private void btnTerasMasaSil_Click(object sender, EventArgs e)
        {
            silinecekTerasMasa = TerasMasaContext.TerasMasalar.Find(x => x.TerasMasaNumarası == txtMasaNumarasi.Text);
            TerasMasaContext.TerasMasalar.Remove(silinecekTerasMasa);
            TerasMasaContext.Save();
            MasalariGetir();
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
        }

        //private void MasaOlustur()
        //{
        //    for (int i = 1; i < 11; i++)
        //    {
        //        Button ilkButon = new Button
        //        {
        //            Name = $"terasMasa{i}",
        //            Text = $"Teras Masa - {i}",
        //            Height = 80,
        //            Width = 80
        //        };
        //        flpTerasMasalar.Controls.Add(ilkButon);
        //    }
        //    for (int i = 1; i < 11; i++)
        //    {
        //        TerasMasa ilkMasalar = new TerasMasa()
        //        {
        //            TerasMasaNumarası = i.ToString()
        //        };
        //        TerasMasaContext.TerasMasalar.Add(ilkMasalar);
        //    }
        //    TerasMasaContext.Save();
        //}
    }
}
