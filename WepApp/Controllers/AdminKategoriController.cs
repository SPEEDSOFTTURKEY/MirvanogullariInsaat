using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminKategoriController : Controller
    {
        public IActionResult Index()
        {
            KategoriRepository kategoriRepository = new KategoriRepository();
            List<Kategori> list = new List<Kategori>();
            list = kategoriRepository.GetirList(x => x.Durumu == 1);
            ViewBag.Kategori = list;
            
            return View();
        }
        public IActionResult Guncelleme(int id)
        {
            KategoriRepository repository = new KategoriRepository();
            Kategori urun = repository.Getir(id);
            if (urun != null)
            {
                HttpContext.Session.SetObjectAsJson("Kategori", urun);
            }
            return RedirectToAction("Index", "AdminKategoriGuncelle");
        }
        public IActionResult Sil(int id)
        {
         KategoriRepository repository = new KategoriRepository();
            Kategori urun = repository.Getir(id);
            if (urun != null)
            {
                urun.Durumu = 0;
                urun.GuncellenmeTarihi = DateTime.Now;
                repository.Guncelle(urun);
            }
            return RedirectToAction("Index", "AdminKategori");
        }

    }
}
