using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;

namespace WebApp.Controllers
{
    public class AdminIletisimBilgileriEkleController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(IletisimBilgileri İletisimBilgileri)
        {
            if (ModelState.IsValid)
            {
                İletisimBilgileri.Durumu = 1;
                İletisimBilgileri.GuncellenmeTarihi = DateTime.Now;
                İletisimBilgileri.EklenmeTarihi=DateTime.Now;
                IletisimBilgileriRepository IletisimBilgileriRepository = new IletisimBilgileriRepository();
                IletisimBilgileriRepository.Ekle(İletisimBilgileri);
                return RedirectToAction("Index", "AdminIletisimBilgileri");
            }
            return View("Index", İletisimBilgileri);
        }
    }
}
