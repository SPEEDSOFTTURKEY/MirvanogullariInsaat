using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using WepApp.Models;

namespace WebApp.Controllers
{
    public class AdminAnaSayfaBannerResimController : Controller
    {
        [Obsolete]
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _HostEnvironment;

        [Obsolete]
        public AdminAnaSayfaBannerResimController(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnvironment)
        {
            _HostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            AnaSayfaBannerResimRepository repository = new AnaSayfaBannerResimRepository();
            List<AnaSayfaBannerResim> modelListesi = repository.Listele().Where(x => x.Durumu == 1).ToList();
            ViewBag.FotografList = modelListesi;

            return View();
        }
        public IActionResult Guncelle(int id)
        {
            AnaSayfaBannerResimRepository repository = new AnaSayfaBannerResimRepository();
            AnaSayfaBannerResim urun = repository.Getir(id);
            if (urun != null)
            {
                HttpContext.Session.SetObjectAsJson("AnaSayfaBanner", urun);
            }
            return RedirectToAction("Index", "AdminAnaSayfaBannerResimGuncelle");
        }
        [Obsolete]
        public IActionResult Sil(int Id)
        {
            string pathBig = string.Empty;
            string pathSmall = string.Empty;
            AnaSayfaBannerResim anaSayfaFotograf = new AnaSayfaBannerResim();
            AnaSayfaBannerResimRepository repository = new AnaSayfaBannerResimRepository();
            anaSayfaFotograf = repository.Getir(Id);
            if (anaSayfaFotograf != null)
            {
                pathBig = _HostEnvironment.ContentRootPath + "\\" + "wwwroot";
                pathSmall = _HostEnvironment.ContentRootPath + "\\" + "wwwroot";
                pathBig += anaSayfaFotograf.FotografBuyuk.Replace("/","\\");
                pathSmall += anaSayfaFotograf.FotografKucuk.Replace("/", "\\");
                if (System.IO.File.Exists(pathBig))
                {
                    System.IO.File.Delete(pathBig);
                }
                if (System.IO.File.Exists(pathSmall))
                {
                    System.IO.File.Delete(pathSmall);
                }
                repository.Sil(anaSayfaFotograf);
            }
            return RedirectToAction("Index", "AdminAnaSayfaBannerResim");
        }
    }
}
