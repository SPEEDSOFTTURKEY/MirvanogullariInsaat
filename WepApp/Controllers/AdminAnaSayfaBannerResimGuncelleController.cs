using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class AdminAnaSayfaBannerResimGuncelleController : Controller
    {
        public IActionResult Index()
        {
            AnaSayfaBannerResim guncellemeBilgisi = HttpContext.Session.GetObjectFromJson<AnaSayfaBannerResim>("AnaSayfaBanner");
            ViewBag.AnaSayfaBannerResim = guncellemeBilgisi;
            return View();
        }
        public IActionResult Kaydet(string Metin, int Id,string Baslik)
        {

            AnaSayfaBannerResimRepository repository = new AnaSayfaBannerResimRepository();
            AnaSayfaBannerResim existingEntity = repository.Getir(Id);
            if (existingEntity != null)
            {
                existingEntity.Metin = Metin;
                existingEntity.Baslik = Baslik;
             

                existingEntity.GuncellenmeTarihi = DateTime.Now;
                repository.Guncelle(existingEntity);
            }
            return RedirectToAction("Index", "AdminAnaSayfaBannerResim");

        }
    }
}
