using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Repositories;
namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        KullanicilarRepository kullanicilarRepository = new KullanicilarRepository();
        [HttpGet]
        public IActionResult Index()
        {
            IletisimBilgileriRepository bilgileriRepository = new IletisimBilgileriRepository();
            var iletisim = bilgileriRepository.Getir(x => x.Durumu == 1);
            if (iletisim != null)
            {
                ViewBag.Iletisim = iletisim;
            }
            HakkimizdaBilgileriRepository hakkimizdabilgileriRepository = new HakkimizdaBilgileriRepository();
            var hakkimizda = hakkimizdabilgileriRepository.Getir(x => x.Durumu == 1);
            if (hakkimizda != null)
            {
                ViewBag.Hakkimizda = hakkimizda;
            }
            AnaSayfaBannerResimRepository anaSayfaBannerResimRepository = new AnaSayfaBannerResimRepository();
            var anasayfa = anaSayfaBannerResimRepository.GetirList(x => x.Durumu == 1);
            if (anasayfa != null)
            {
                ViewBag.AnaSayfaBanner = anasayfa;
            }

            //DataContext context = new DataContext();
            //ViewBag.Firma = context.Firma.Take(1).FirstOrDefault();
            return View();
        }


        [HttpPost]
        public IActionResult Giris(string KullaniciAdi, string Sifre)
        {
            kullanicilarRepository = new KullanicilarRepository();
            List<Kullanicilar> kullanicilarListe = new List<Kullanicilar>();
            kullanicilarListe = kullanicilarRepository.Listele().Where(x => x.Adi == KullaniciAdi && x.Sifre == Sifre).ToList();
            Kullanicilar kullanici = new Kullanicilar();
            if(kullanicilarListe.Count>0)
            {
                kullanici = kullanicilarListe[0];
                if(kullanici!=null)
                {
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "Kullanici", kullanici);
                    return RedirectToAction("Index", "AdminAnaSayfa");
                }
            }
            return View("Index");




        }

    }
}
