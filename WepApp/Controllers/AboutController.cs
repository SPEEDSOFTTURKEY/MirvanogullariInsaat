using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;

namespace WebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;

            HakkimizdaBilgileriRepository repository = new HakkimizdaBilgileriRepository();

            HakkimizdaBilgileri modelListesi = repository.Getir(x => x.Durumu == 1);

            ViewBag.HakkimizdaBilgileriList = modelListesi;
            HakkimizdaFotografRepository fotorepository = new HakkimizdaFotografRepository();

            HakkimizdaFotograf fotoListesi = fotorepository.Getir(x => x.Durumu == 1);

            ViewBag.FotografList = fotoListesi;
            return View();
        }
    }
}
