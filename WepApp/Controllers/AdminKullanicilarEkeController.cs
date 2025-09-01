using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;

namespace WebApp.Controllers
{
    public class AdminKullanicilarEkeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kullanicilar kullanicilar)
        {
            if (ModelState.IsValid)
            {
                KullanicilarRepository BilgileriRepository = new KullanicilarRepository();
                kullanicilar.EklenmeTarihi = DateTime.Now;
                kullanicilar.GuncellenmeTarihi = DateTime.Now;
                kullanicilar.Durumu = 1;
                BilgileriRepository.Ekle(kullanicilar);
                return RedirectToAction("Index", "AdminKullanicilar");
            }
            return View("Index", kullanicilar);
        }
    }
}
