namespace WebApp.Models
{
    public class ServiceDetailViewModel
    {
        public string ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Features { get; set; }
        public string AdditionalInfo { get; set; }
        public string ImageUrl { get; set; }
    }
}