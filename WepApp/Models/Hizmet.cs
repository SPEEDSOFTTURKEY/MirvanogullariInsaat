namespace WepApp.Models
{
    public class Hizmet
    {
        public int Id { get; set; }
        public string? Metin { get; set; }

        public int? Durumu { get; set; }

        public DateTime? EklenmeTarihi { get; set; }

        public DateTime? GuncellenmeTarihi { get; set; }

        public string? Baslik { get; set; }
    }
}
