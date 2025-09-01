namespace WepApp.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        public int Durumu { get; set; }
    }
}
