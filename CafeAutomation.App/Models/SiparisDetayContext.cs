using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.App.Models
{
    public static class SiparisDetayContext
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
            "/Veritabanı/siparisDetaylar.json";
        public static List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();

        public static void Load()
        {
            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    SiparisDetaylar = JsonConvert.DeserializeObject<List<SiparisDetay>>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory((Environment.SpecialFolder.Desktop) + "/Veritabanı");
            }
        }

        public static void Save()
        {
            try
            {
                File.Delete(_path);
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(SiparisDetaylar, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
