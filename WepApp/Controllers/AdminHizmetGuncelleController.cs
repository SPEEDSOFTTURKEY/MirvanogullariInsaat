using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminHizmetGuncelleController : Controller
    {
        public IActionResult Index()
        {
            Hizmet guncellemeBilgisi = HttpContext.Session.GetObjectFromJson<Hizmet>("Hizmet");
            ViewBag.Hizmet = guncellemeBilgisi;
            return View();
        }
        public IActionResult Kaydet(Hizmet hakkimizdaBilgileri)
        {

            HizmetRepository repository = new HizmetRepository();
            Hizmet existingEntity = repository.Getir(hakkimizdaBilgileri.Id);
                if (existingEntity != null)
                {
                    existingEntity.Metin = hakkimizdaBilgileri.Metin;
                    existingEntity.Baslik = hakkimizdaBilgileri.Baslik;
              
                    existingEntity.GuncellenmeTarihi = DateTime.Now;
                    repository.Guncelle(existingEntity);
                }
                return RedirectToAction("Index", "AdminHizmet");
   
        }
    }
}
