using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class MesajController : Controller
    {
        public IActionResult Index()
        {

            AnaSayfaBannerResimRepository anaSayfaBannerResimRepository = new AnaSayfaBannerResimRepository();
            List<AnaSayfaBannerResim> anaSayfaBannerResim = new List<AnaSayfaBannerResim>();
            anaSayfaBannerResim = anaSayfaBannerResimRepository.GetirList(x => x.Durumu == 1);
            ViewBag.AnaSayfaBanner = anaSayfaBannerResim;

            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;
            string Mesaj = "Mesajınız Tarafımıza Ulaşmıştır En Kısa Sürede E-posta Adresinize Dönüş Sağlanakcaktır";
            ViewBag.Mesaj = Mesaj;
            return View();
        }
    }
}
