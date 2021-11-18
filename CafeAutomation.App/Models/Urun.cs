using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.App.Models
{
    public class Urun
    {
        public string UrunAdi { get; set; }

        public string Fiyat { get; set; }

        public string Kategori { get; set; }

        public override string ToString() => $"{UrunAdi}             {Fiyat}.00₺              {Kategori}";
    }
}
