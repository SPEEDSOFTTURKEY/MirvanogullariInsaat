using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;

namespace WepApp.Controllers
{
    public class ProjectDetailsController : Controller
    {
        public IActionResult Index()
        {
            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;

            return View();
        }
    }
}
