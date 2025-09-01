using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AdminAnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
