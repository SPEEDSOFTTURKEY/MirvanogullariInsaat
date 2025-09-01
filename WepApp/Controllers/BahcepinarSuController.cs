using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;

namespace WepApp.Controllers
{
    public class BahcepinarSuController : Controller
    {
        public IActionResult Index()
        {
            IletisimBilgileriRepository �letisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri �letisimBilgileri = new IletisimBilgileri();
            �letisimBilgileri = �letisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = �letisimBilgileri;
            return View();
        }
    }
}
