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
                    Height = 80,
                    Width = 80
                };
                masaButon.Click += new EventHandler(YeniButon_Click);
                flpBahceMasalar.Controls.Add(masaButon);
            }
        }

        protected void YeniButon_Click(object sender,EventArgs e)
        {
            //YeniForm açma ve butonları gösterme kodlarını buraya yaz
            MessageBox.Show("Heyyyyy");
        }

        private void FrmBahceMasalar_Load(object sender, EventArgs e)
        {
            MasaOlustur();
            flpBahceMasalar.Controls.Clear();
            BahceMasaContext.Load();
            MasalariGetir();
        }

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            BahceMasa yeniBahceMasa = new BahceMasa()
            {
                BahceMasaNumarası = txtMasaNumarasi.Text
            };
            BahceMasaContext.BahceMasalar.Add(yeniBahceMasa);
            flpBahceMasalar.Controls.Clear();
            MasalariGetir();
            BahceMasaContext.Save();
        }

        private void MasaOlustur()
        {
            for (int i = 1; i < 11; i++)
            {
                Button ilkButon = new Button
                {
                    Name = $"bahceMasa{i}",
                    Text = $"Bahçe Masa - {i}",
                    Height = 80,
                    Width = 80
                };
                flpBahceMasalar.Controls.Add(ilkButon);
            }
            for (int i = 1; i < 11; i++)
            {
                BahceMasa ilkMasalar = new BahceMasa()
                {
                    BahceMasaNumarası = i.ToString()
                };
                BahceMasaContext.BahceMasalar.Add(ilkMasalar);
            }
            BahceMasaContext.Save();
        }

        private BahceMasa silinecekBahceMasa;
        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            silinecekBahceMasa = BahceMasaContext.BahceMasalar.Find(x => x.BahceMasaNumarası == txtMasaNumarasi.Text);
            BahceMasaContext.BahceMasalar.Remove(silinecekBahceMasa);
            BahceMasaContext.Save();
            MasalariGetir();
        }
    }
}
