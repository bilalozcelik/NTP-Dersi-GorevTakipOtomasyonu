
namespace GorevTakipOtomasyonu.Models
{
    /// <summary>
    /// Görevlerin öncelik seviyelerini belirleyen Enum sabiti.
    /// </summary>
    public enum Oncelik
    {
        Dusuk,
        Orta,
        Yuksek
    }

    /// <summary>
    /// Uygulamadaki her bir "Görev" nesnesini temsil eden Model sınıfı.
    /// Nesneye Dayalı Programlama (OOP) prensiplerine göre veriyi tutar.
    /// </summary>
    public class Gorev
    {
        // Benzersiz kimlik (ID) - Her görevi birbirinden ayırmak için kullanılır
        public Guid Id { get; set; } = Guid.NewGuid();
        
        // Görevin başlığı
        public string Baslik { get; set; } = string.Empty;
        
        // Görevin detaylı açıklaması
        public string Aciklama { get; set; } = string.Empty;
        
        // Enum tipindeki öncelik durumu
        public Oncelik GorevOnceligi { get; set; } = Oncelik.Orta;
        
        // Kaydın oluşturulduğu zaman bilgisi
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        
        // Görevin yapılıp yapılmadığını belirten mantıksal değer (true/false)
        public bool TamamlandiMi { get; set; } = false;

        /// <summary>
        /// ListBox veya ComboBox gibi kontrollerde nesnenin nasıl görüneceğini belirler.
        /// </summary>
        public override string ToString()
        {
            string durum = TamamlandiMi ? "[✔]" : "[ ]";
            return $"{durum} {Baslik} ({GorevOnceligi})";
        }
    }
}
