using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;

namespace WepApp.Controllers
{
    public class BahcepinarSuController : Controller
    {
        public IActionResult Index()
        {
            IletisimBilgileriRepository ýletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ýletisimBilgileri = new IletisimBilgileri();
            ýletisimBilgileri = ýletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ýletisimBilgileri;
            return View();
        }
    }
}
