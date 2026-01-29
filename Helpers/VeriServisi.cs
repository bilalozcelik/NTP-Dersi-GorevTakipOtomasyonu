
using System.Text.Json;
using GorevTakipOtomasyonu.Models;

namespace GorevTakipOtomasyonu.Helpers
{
    public static class VeriServisi
    {
        private static readonly string dosyaYolu = "gorevler.json";

        public static void Kaydet(List<Gorev> gorevler)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(gorevler, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dosyaYolu, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception("Kaydetme hatası: " + ex.Message);
            }
        }

        public static List<Gorev> Yukle()
        {
            try
            {
                if (!File.Exists(dosyaYolu)) return new List<Gorev>();

                string jsonString = File.ReadAllText(dosyaYolu);
                return JsonSerializer.Deserialize<List<Gorev>>(jsonString) ?? new List<Gorev>();
            }
            catch
            {
                return new List<Gorev>();
            }
        }
    }
}
