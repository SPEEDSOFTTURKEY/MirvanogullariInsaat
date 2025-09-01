using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminHizmetController : Controller
    {
        public IActionResult Index()
        {

            HizmetRepository repository = new HizmetRepository();

            List<Hizmet> modelListesi = repository.Listele().Where(x => x.Durumu == 1).ToList();

            ViewBag.Hizmet = modelListesi;

            return View();
        }


        public IActionResult Guncelleme(int id)
        {
            HizmetRepository repository = new HizmetRepository();
            Hizmet hakkimizdaBilgileri = repository.Getir(id);

            if (hakkimizdaBilgileri != null)
            {
                HttpContext.Session.SetObjectAsJson("Hizmet", hakkimizdaBilgileri);
            }
            return RedirectToAction("Index", "AdminHizmetGuncelle");
        }


        public IActionResult Sil(int id)
        {
            HizmetRepository repository = new HizmetRepository();

            Hizmet hakkimizdaBilgileri = repository.Getir(id);

            if (hakkimizdaBilgileri != null)
            {
                hakkimizdaBilgileri.Durumu = 0;
                hakkimizdaBilgileri.GuncellenmeTarihi = DateTime.Now;
                repository.Guncelle(hakkimizdaBilgileri);
            }

            return RedirectToAction("Index", "AdminHizmet");
        }
    }
}
