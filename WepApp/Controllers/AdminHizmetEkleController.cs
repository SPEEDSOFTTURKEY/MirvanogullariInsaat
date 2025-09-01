using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class AdminHizmetEkleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Hizmet hakkimizdaBilgileri)
        {

            HizmetRepository Repository = new HizmetRepository();
                hakkimizdaBilgileri.EklenmeTarihi = DateTime.Now;
                hakkimizdaBilgileri.GuncellenmeTarihi = DateTime.Now;
                hakkimizdaBilgileri.Durumu = 1;
                Repository.Ekle(hakkimizdaBilgileri);
                return RedirectToAction("Index", "AdminHizmet");
            
        }
    }
}
