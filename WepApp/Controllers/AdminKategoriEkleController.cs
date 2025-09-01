using Microsoft.AspNetCore.Mvc;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminKategoriEkleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kategori urun)
        {
          
                KategoriRepository BilgileriRepository = new KategoriRepository();
                urun.EklenmeTarihi = DateTime.Now;
                urun.GuncellenmeTarihi = DateTime.Now;
                urun.Durumu = 1;
                BilgileriRepository.Ekle(urun);
                return RedirectToAction("Index", "AdminKategori");
            }
        
    }
}
