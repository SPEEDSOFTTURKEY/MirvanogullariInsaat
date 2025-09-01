using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;

namespace WebApp.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IletisimBilgileriRepository _iletisimBilgileriRepository;


        public IActionResult Index()
        {
            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;

            return View();
        }

        public IActionResult ServicesDetails(string service)
        {
            var iletisimBilgileri = _iletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = iletisimBilgileri;

            var model = GetServiceDetails(service);
            if (model == null)
            {
                return NotFound();
            }

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
                        Title = "Boya Badana",
                        Description = "Kalabalık ekibimizle yaşam alanlarınızı yeniden boyuyor, gereken alanlarda rötuşlar ve tadilatlar yapıyoruz. En uygun fiyat ve en iyi hizmet kalitesiyle boyuyoruz.",
                        Features = new List<string>
                        {
                            "Yüksek kaliteli boya malzemeleri",
                            "Hızlı ve temiz işçilik",
                            "Uygun fiyat garantisi"
                        },
                        AdditionalInfo = "Yaşam alanlarınızı yenilemek için profesyonel ekibimizle hizmetinizdeyiz.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2020/08/mamak-boya-badana-ustasi-360x247.jpg"
                    };
                case "tadilat-tamirat":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "tadilat-tamirat",
                        Title = "Tadilat Tamirat",
                        Description = "Dekorasyon amaçlı yapılan ürünlere nazaran daha uygun bütçelerle yapılan işlemlerdir. Boya badana konusunda sıklıkla yapılan tamirat işlemi ise, duvar onarımı olmaktadır.",
                        Features = new List<string>
                        {
                            "Duvar onarımı",
                            "Küçük ölçekli tadilatlar",
                            "Ekonomik çözümler"
                        },
                        AdditionalInfo = "Ev ve ofisleriniz için hızlı ve güvenilir tadilat hizmetleri sunuyoruz.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2020/08/ankara-ev-ofis-tadilati-360x247.jpg"
                    };
                case "fayans-doseme":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "fayans-doseme",
                        Title = "Fayans Döşeme",
                        Description = "Fayanslar binaların iç alanlarında kullanılmaktadır. Duvarlarda kullanımı yaygındır. Seramikler ise, iç ve dış alanlarda kullanılabilir. Daha renkli ve desenlidir. Yer döşemelerinde sıklıkla tercih edilmektedir.",
                        Features = new List<string>
                        {
                            "Dayanıklı fayans ve seramik malzemeler",
                            "Estetik ve modern tasarımlar",
                            "Profesyonel döşeme hizmeti"
                        },
                        AdditionalInfo = "Fayans ve seramik döşeme ile mekanlarınızı güzelleştiriyoruz.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2020/08/ankara-mamak-fayans-ustasi-360x247.jpg"
                    };
                case "alci-siva-kartonpiyer":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "alci-siva-kartonpiyer",
                        Title = "Alçı Sıva Kartonpiyer",
                        Description = "Alçı sıva: tuğla, beton ya da ytong (gazbeton) malzemelerinin ya da kaba sıva maddesinin üzerine çekilerek boyadan önce kat oluşturmak amaçlı yapılan yüzeye denilmektedir.",
                        Features = new List<string>
                        {
                            "Pürüzsüz yüzey oluşturma",
                            "Dekoratif kartonpiyer uygulamaları",
                            "Hızlı uygulama"
                        },
                        AdditionalInfo = "Alçı ve kartonpiyer ile iç mekanlarınıza şıklık katıyoruz.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2020/08/alci-kartonpiyer-siva-uygulamasi-360x247.jpg"
                    };
                case "mutfak-tezgahi":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "mutfak-tezgahi",
                        Title = "Mutfak Tezgahı",
                        Description = "Yaşam alanlarınız için mutfak alanlarında tezgahları yenilemeye geliyoruz. Kaliteli malzeme uygun fiyat için hemen iletişime geçmek için çekinmeyin.",
                        Features = new List<string>
                        {
                            "Dayanıklı ve şık tezgah malzemeleri",
                            "Özelleştirilebilir tasarımlar",
                            "Hızlı montaj"
                        },
                        AdditionalInfo = "Mutfaklarınızı modern ve kullanışlı hale getiriyoruz.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2016/05/kitchen-673733_640-360x247.jpg"
                    };
                case "cevre-duzenleme-kilit-parke":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "cevre-duzenleme-kilit-parke",
                        Title = "Çevre Düzenleme Kilit Parke",
                        Description = "Dış alanlarda çevre düzenlemesi yaparken bordür, kilit taşı ve karo döşemesi büyük önem arz etmekte olup görsel olarak önemlidir. En uygun fiyata ve kaliteli ustalık ile kilit taşı yaptırmak için hemen iletişime geçin.",
                        Features = new List<string>
                        {
                            "Estetik kilit taşı döşeme",
                            "Dayanıklı bordür uygulamaları",
                            "Çevre dostu malzemeler"
                        },
                        AdditionalInfo = "Dış mekanlarınızı güzelleştirmek için profesyonel hizmet sunuyoruz.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2020/08/ankara-kilit-tas-parke-tasi-doseme-360x247.jpg"
                    };
                case "dis-cephe-mantolama":
                    return new ServiceDetailViewModel
                    {
                        ServiceId = "dis-cephe-mantolama",
                        Title = "Dış Cephe Mantolama",
                        Description = "Mantolama işlemi binalarda ısı yalıtımı için yapılmaktadır. Dış cephe mantolama, iç cephe ve sandviç şeklinde üç çeşit mantolama seçeneği bulunmaktadır. Bunların içinden en etkilisi ve en kapsamlısı dış cephe mantolamasıdır.",
                        Features = new List<string>
                        {
                            "Yüksek ısı yalıtımı",
                            "Enerji tasarrufu",
                            "Dayanıklı dış cephe kaplamaları"
                        },
                        AdditionalInfo = "Binalarınızı enerji verimli hale getirmek için dış cephe mantolama hizmetimizden yararlanın.",
                        ImageUrl = "https://adcankayainsaat.com.tr/wp-content/uploads/2020/08/ankara-mamak-mantolama-firmasi-360x247.jpg"
                    };
                default:
                    return null;
            }
        }
    }
}