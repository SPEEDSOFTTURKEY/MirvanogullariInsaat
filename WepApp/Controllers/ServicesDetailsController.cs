using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;

namespace WebApp.Controllers
{
    public class ServicesDetailsController : Controller
    {
        private readonly IletisimBilgileriRepository _iletisimBilgileriRepository;

   

        public IActionResult Index(string service)
        {
            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;

            var model = GetServiceDetails(service?.ToLower());
            return View(model);
        }

        private ServiceDetailViewModel GetServiceDetails(string serviceId)
        {
            switch (serviceId)
            {
           
                case "boya-badana":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "boya-badana",
                        Title = "Boya ve Badana Hizmetleri",
                        Description = "Profesyonel boya ve badana hizmetlerimizle mekanlarınıza yeni bir soluk getiriyoruz. Kaliteli malzemeler ve uzman işçilikle, iç ve dış cephelerinizi yeniliyoruz.",
                        Features = new List<string>
                        {
                            "Çevre dostu ve dayanıklı boya seçenekleri",
                            "Hızlı ve temiz uygulama süreci",
                            "Renk danışmanlığı ve kişiselleştirilmiş çözümler",
                            "Uzun ömürlü ve estetik sonuçlar"
                        },
                        AdditionalInfo = "Boya ve badana hizmetlerimizde, her detayı titizlikle planlayarak mekanlarınızı hem estetik hem de fonksiyonel hale getiriyoruz. Müşteri memnuniyeti odaklı yaklaşımımızla, hayallerinizdeki renkleri gerçeğe dönüştürüyoruz.",
                        ImageUrl = "/WebUITheme/Hizmetler/boyabadana.jpg"
                    };
                case "tadilat-tamirat":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "tadilat-tamirat",
                        Title = "Tadilat ve Tamirat Hizmetleri",
                        Description = "Ev veya iş yerleriniz için kapsamlı tadilat ve tamirat hizmetleri sunuyoruz. Küçük onarımlardan büyük yenileme projelerine kadar her ihtiyaca uygun çözümler üretiyoruz.",
                        Features = new List<string>
                        {
                            "Kapsamlı tadilat planlama ve uygulama",
                            "Yüksek kaliteli malzeme kullanımı",
                            "Zamanında teslim ve bütçe dostu çözümler",
                            "Deneyimli ve güvenilir ekip"
                        },
                        AdditionalInfo = "Tadilat ve tamirat projelerimizde, müşterilerimizin ihtiyaçlarını dikkatle analiz ederek, hem estetik hem de dayanıklı sonuçlar elde ediyoruz. Mekanlarınızı yenilerken konforunuzu en üst düzeye çıkarıyoruz.",
                        ImageUrl = "/WebUITheme/Hizmetler/tamirtadilat.jpg"
                    };
                case "fayans-doseme":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "fayans-doseme",
                        Title = "Fayans Döşeme Hizmetleri",
                        Description = "Banyo, mutfak ve diğer yaşam alanlarınız için şık ve dayanıklı fayans döşeme hizmetleri sunuyoruz. Modern tasarımlar ve kaliteli işçilikle mekanlarınızı güzelleştiriyoruz.",
                        Features = new List<string>
                        {
                            "Çeşitli desen ve malzeme seçenekleri",
                            "Hassas ve düzgün döşeme teknikleri",
                            "Kolay temizlenebilir ve uzun ömürlü yüzeyler",
                            "Proje sürecinde tam destek"
                        },
                        AdditionalInfo = "Fayans döşeme hizmetlerimizde, her zevke uygun tasarımlar sunarak mekanlarınızı hem işlevsel hem de estetik hale getiriyoruz. Kalite ve dayanıklılığı bir araya getiren çözümlerimizle fark yaratıyoruz.",
                        ImageUrl = "/WebUITheme/Hizmetler/fayans.jpg"
                    };
                case "alci-siva-kartonpiyer":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "alci-siva-kartonpiyer",
                        Title = "Alçı, Sıva ve Kartonpiyer Hizmetleri",
                        Description = "İç mekanlarınıza zarif bir dokunuş katmak için alçı, sıva ve kartonpiyer hizmetleri sunuyoruz. Estetik ve dayanıklılığı birleştiren uygulamalarımızla fark yaratıyoruz.",
                        Features = new List<string>
                        {
                            "Modern ve dekoratif kartonpiyer tasarımları",
                            "Pürüzsüz ve dayanıklı sıva uygulamaları",
                            "Hızlı ve temiz çalışma süreci",
                            "Kişiselleştirilmiş dekorasyon çözümleri"
                        },
                        AdditionalInfo = "Alçı, sıva ve kartonpiyer hizmetlerimizle, mekanlarınızı daha şık ve konforlu hale getiriyoruz. Uzman ekibimiz, her detayı özenle işleyerek mükemmel sonuçlar sunar.",
                        ImageUrl = "/WebUITheme/Hizmetler/alcisiva.jpg"
                    };
                case "mutfak-tezgahi":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "mutfak-tezgahi",
                        Title = "Mutfak Tezgahı Hizmetleri",
                        Description = "Mutfaklarınızı hem işlevsel hem de estetik hale getirmek için özel tasarım mutfak tezgahları sunuyoruz. Dayanıklı malzemeler ve modern tasarımlarla mutfaklarınıza değer katıyoruz.",
                        Features = new List<string>
                        {
                            "Granit, kuvars ve mermer tezgah seçenekleri",
                            "Kişiselleştirilmiş tasarım ve ölçü hizmetleri",
                            "Kolay temizlenebilir ve hijyenik yüzeyler",
                            "Hızlı ve profesyonel montaj"
                        },
                        AdditionalInfo = "Mutfak tezgahı hizmetlerimizde, estetik ve fonksiyonelliği bir araya getirerek mutfaklarınızı yeniliyoruz. Her ihtiyaca uygun çözümlerimizle, kullanım kolaylığı ve şıklığı garanti ediyoruz.",
                        ImageUrl = "/WebUITheme/Hizmetler/mutfaktezgahı.jpg"
                    };
                case "cevre-duzenleme-kilit-parke":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "cevre-duzenleme-kilit-parke",
                        Title = "Çevre Düzenleme ve Kilit Parke Hizmetleri",
                        Description = "Dış mekanlarınızı güzelleştirmek için çevre düzenleme ve kilit parke hizmetleri sunuyoruz. Bahçeler, yürüyüş yolları ve avlular için estetik ve dayanıklı çözümler üretiyoruz.",
                        Features = new List<string>
                        {
                            "Dayanıklı ve estetik kilit parke uygulamaları",
                            "Peyzaj tasarımı ve çevre düzenleme",
                            "Çevre dostu malzeme kullanımı",
                            "Hızlı ve düzenli uygulama süreci"
                        },
                        AdditionalInfo = "Çevre düzenleme ve kilit parke hizmetlerimizle, dış mekanlarınızı hem kullanışlı hem de göz alıcı hale getiriyoruz. Doğayla uyumlu tasarımlarımızla yaşam alanlarınıza değer katıyoruz.",
                        ImageUrl = "/WebUITheme/Hizmetler/cevreduzenleme.jpg"
                    };
                case "dis-cephe-mantolama":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "dis-cephe-mantolama",
                        Title = "Dış Cephe Mantolama Hizmetleri",
                        Description = "Binalarınızı enerji verimli ve estetik hale getirmek için dış cephe mantolama hizmetleri sunuyoruz. Isı yalıtımı ve modern görünümle binalarınıza değer katıyoruz.",
                        Features = new List<string>
                        {
                            "Yüksek enerji tasarrufu sağlayan yalıtım",
                            "Dayanıklı ve modern dış cephe kaplamaları",
                            "Hava koşullarına karşı koruma",
                            "Profesyonel uygulama ve garanti"
                        },
                        AdditionalInfo = "Dış cephe mantolama hizmetlerimizle, binalarınızı hem enerji tasarruflu hem de estetik açıdan yeniliyoruz. Uzman ekibimiz, uzun ömürlü ve çevre dostu çözümler sunar.",
                        ImageUrl = "/WebUITheme/Hizmetler/montalama.jpg"
                    };
                default:
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "dis-cephe-mantolama",
                        Title = "Dış Cephe Mantolama Hizmetleri",
                        Description = "Binalarınızı enerji verimli ve estetik hale getirmek için dış cephe mantolama hizmetleri sunuyoruz. Isı yalıtımı ve modern görünümle binalarınıza değer katıyoruz.",
                        Features = new List<string>
                        {
                            "Yüksek enerji tasarrufu sağlayan yalıtım",
                            "Dayanıklı ve modern dış cephe kaplamaları",
                            "Hava koşullarına karşı koruma",
                            "Profesyonel uygulama ve garanti"
                        },
                        AdditionalInfo = "Dış cephe mantolama hizmetlerimizle, binalarınızı hem enerji tasarruflu hem de estetik açıdan yeniliyoruz. Uzman ekibimiz, uzun ömürlü ve çevre dostu çözümler sunar.",
                        ImageUrl = "/WebUITheme/Hizmetler/montalama.jpg"
                    };
            }
        }
    }
}
