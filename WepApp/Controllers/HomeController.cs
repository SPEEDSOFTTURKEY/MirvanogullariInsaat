using Microsoft.AspNetCore.Mvc;
using WebApp.Repositories;
using WebApp.Models;
using WepApp.Models;
using WepApp.Repositories;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int Id)
        {
            HakkimizdaFotografRepository fotorepository = new HakkimizdaFotografRepository();

            HakkimizdaFotograf fotoListesi = fotorepository.Getir(x => x.Durumu == 1);

            ViewBag.FotografList = fotoListesi;
            AnaSayfaBannerResimRepository anaSayfaBannerResimRepository = new AnaSayfaBannerResimRepository();
           List<AnaSayfaBannerResim> anaSayfaBannerResim = new List<AnaSayfaBannerResim>();
            anaSayfaBannerResim = anaSayfaBannerResimRepository.GetirList(x => x.Durumu == 1);
            ViewBag.AnaSayfaBanner = anaSayfaBannerResim;

            HakkimizdaBilgileriRepository repository = new HakkimizdaBilgileriRepository();

            HakkimizdaBilgileri modelListesi = repository.Getir(x => x.Durumu == 1);
            ViewBag.HakkimizdaBilgileriList = modelListesi;
            IletisimBilgileriRepository ıletisimBilgileriRepository = new IletisimBilgileriRepository();
            IletisimBilgileri ıletisimBilgileri = new IletisimBilgileri();
            ıletisimBilgileri = ıletisimBilgileriRepository.Getir(x => x.Durumu == 1);
            ViewBag.Iletisim = ıletisimBilgileri;

            KategoriRepository kategoriRepository = new KategoriRepository();
            List<Kategori> kategoris = kategoriRepository.GetirList(x => x.Durumu == 1);
            ViewBag.Kategori = kategoris;

            GaleriFotografRepository galeriFotografRepository = new GaleriFotografRepository();
            List<string> join = new List<string>();
            join.Add("Kategori");
            List<GaleriFotograf> galeri = galeriFotografRepository.GetirList(x => x.Durumu == 1, join);
            ViewBag.GaleriFotograflar = galeri;




            return View();


        }

     
    }
}
