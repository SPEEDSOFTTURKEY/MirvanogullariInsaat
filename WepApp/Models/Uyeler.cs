namespace WebApp.Models
{
	public class Uyeler
	{
		public int Id { get; set; }

		public string? Adi { get; set; }
		public string? Soyadi { get; set; }
		public string ? KullaniciAdi {  get; set; }
		public string? Sifre { get; set; }
		public string? EMail { get; set; }
		public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public int? Durumu { get; set; }

		public DateTime? EklenmeTarihi { get; set; }

		public DateTime? GuncellenmeTarihi { get; set; }
	}
}
