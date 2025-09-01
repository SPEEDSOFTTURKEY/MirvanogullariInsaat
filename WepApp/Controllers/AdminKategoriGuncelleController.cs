using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminKategoriGuncelleController : Controller
    {
        public IActionResult Index()
        {
            Kategori guncellemeBilgisi = HttpContext.Session.GetObjectFromJson<Kategori>("Kategori");
            ViewBag.Kategori = guncellemeBilgisi;
            return View();
        }
        public IActionResult Kaydet(Kategori urunTip)
        {
         
                KategoriRepository repository = new KategoriRepository();
                Kategori existingEntity = repository.Getir(urunTip.Id);
                if (existingEntity != null)
                {
                    existingEntity.Adi = urunTip.Adi;
                    existingEntity.GuncellenmeTarihi = DateTime.Now;
                    repository.Guncelle(existingEntity);
                }
                return RedirectToAction("Index", "AdminKategori");
            
        }
    }
}
