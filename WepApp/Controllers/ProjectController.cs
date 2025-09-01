using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;
using WepApp.Repositories;

namespace WepApp.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
        
            KategoriRepository kategoriRepository = new KategoriRepository();
            List<Kategori> kategoris = kategoriRepository.GetirList(x => x.Durumu == 1);
            ViewBag.Kategori = kategoris;

            GaleriFotografRepository galeriFotografRepository = new GaleriFotografRepository();
            List<string> join = new List<string>();
            join.Add("Kategori");
            List<GaleriFotograf> galeri = galeriFotografRepository.GetirList(x => x.Durumu == 1,join);
            ViewBag.GaleriFotograflar = galeri;
            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;

            return View();
        }
    }
}
