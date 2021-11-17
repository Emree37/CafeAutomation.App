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
    public static class KapatilanSiparislerContext
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
            "/Veritabanı/kapatilanSiparisler.json";

        public static List<KapatilanSiparisler> KapatilanSiparisler { get; set; } = new List<KapatilanSiparisler>();

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
                    KapatilanSiparisler = JsonConvert.DeserializeObject<List<KapatilanSiparisler>>(dosyaIcerigi);
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
                writer.Write(JsonConvert.SerializeObject(KapatilanSiparisler, Formatting.Indented));
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
