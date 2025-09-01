using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminKullaniciMesajGuncelleController : Controller
    {
        public IActionResult Index()
        {
            KullaniciMesaj guncellemeBilgisi = HttpContext.Session.GetObjectFromJson<KullaniciMesaj>("KullaniciMesaj");
            ViewBag.Mesaj = guncellemeBilgisi;
            return View();
        }

        public IActionResult Kaydet(KullaniciMesaj kullaniciMesaj)
        {
            KullaniciMesajRepository kullaniciMesajRepository = new KullaniciMesajRepository();
            KullaniciMesaj existingEntity = kullaniciMesajRepository.Getir(kullaniciMesaj.Id);
            if (existingEntity != null)
            {

                existingEntity.AdSoyadi = kullaniciMesaj.AdSoyadi;
                existingEntity.Email = kullaniciMesaj.Email;
                existingEntity.Mesaj = kullaniciMesaj.Mesaj;
                existingEntity.GuncellenmeTarihi = DateTime.Now;
                kullaniciMesajRepository.Guncelle(existingEntity);

            }
            return RedirectToAction("Index", "AdminKullaniciMesaj");
        }
    }
}
