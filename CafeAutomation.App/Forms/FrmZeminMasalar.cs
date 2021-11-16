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
                    Height = 80,
                    Width = 80
                };
                masaButon.Click += new EventHandler(YeniButon_Click);
                flpZeminMasalar.Controls.Add(masaButon);
            }
        }

        private void YeniButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Heyyyy");
        }

        private ZeminMasa silinecekZeminMasa;
        private void btnZeminMasaSil_Click(object sender, EventArgs e)
        {
            silinecekZeminMasa = ZeminMasaContext.ZeminMasalar.Find(x => x.ZeminMasaNumarası == txtMasaNumarasi.Text);
            ZeminMasaContext.ZeminMasalar.Remove(silinecekZeminMasa);
            ZeminMasaContext.Save();
            MasalariGetir();
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
        }

        //private void MasaOlustur()
        //{
        //    for (int i = 1; i < 11; i++)
        //    {
        //        Button ilkButon = new Button
        //        {
        //            Name = $"zeminMasa{i}",
        //            Text = $"Zemin Masa - {i}",
        //            Height = 80,
        //            Width = 80
        //        };
        //        flpZeminMasalar.Controls.Add(ilkButon);
        //    }
        //    for (int i = 1; i < 11; i++)
        //    {
        //        ZeminMasa ilkMasalar = new ZeminMasa()
        //        {
        //            ZeminMasaNumarası = i.ToString()
        //        };
        //        ZeminMasaContext.ZeminMasalar.Add(ilkMasalar);
        //    }
        //    ZeminMasaContext.Save();
        //}


        private void FrmZeminMasalar_Load(object sender, EventArgs e)
        {
            //MasaOlustur();
            flpZeminMasalar.Controls.Clear();
            ZeminMasaContext.Load();
            MasalariGetir();
        }
    }
}
