namespace WepApp.Models
{
    public class KullaniciMesaj
    {
        public int Id { get; set; }
        public int Durumu { get; set; }
        public string AdSoyadi { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
    }
}
