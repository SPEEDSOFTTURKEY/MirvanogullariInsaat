using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminKullaniciMesajController : Controller
    {
        public IActionResult Index()
        {
            KullaniciMesajRepository kullaniciMesajRepository = new KullaniciMesajRepository();
            List<KullaniciMesaj> kullaniciMesaj = new List<KullaniciMesaj>();
            kullaniciMesaj = kullaniciMesajRepository.GetirList(x => x.Durumu == 1);
            ViewBag.Mesaj = kullaniciMesaj;
            return View();
        }
        public IActionResult Guncelle(int id)
        {
            KullaniciMesajRepository repository = new KullaniciMesajRepository();
            KullaniciMesaj hakkimizdaBilgileri = repository.Getir(id);

            if (hakkimizdaBilgileri != null)
            {
                HttpContext.Session.SetObjectAsJson("KullaniciMesaj", hakkimizdaBilgileri);
            }
            return RedirectToAction("Index", "AdminKullaniciMesajGuncelle");
        }

        public IActionResult Sil(int id) {
            KullaniciMesajRepository kullaniciMesajRepository = new KullaniciMesajRepository();
            KullaniciMesaj kullaniciMesaj = new KullaniciMesaj();
            kullaniciMesaj = kullaniciMesajRepository.Getir(id);
            if(kullaniciMesaj != null)
            {
                kullaniciMesaj.Durumu = 0;
                kullaniciMesaj.GuncellenmeTarihi=DateTime.Now;
                kullaniciMesajRepository.Guncelle(kullaniciMesaj);
            }
            return RedirectToAction("Index", "AdminKullaniciMesaj");
            


        }
    }
}
