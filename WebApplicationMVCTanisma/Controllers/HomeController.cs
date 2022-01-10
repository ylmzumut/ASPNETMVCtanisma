using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVCTanisma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Deneme()
        {
            //ViewBag Nedir?
            ViewBag.Ad = "Umut";
            //ViewData
            ViewData["Ad"] = "Haydar";
            //ViewData ile ViewBag birbirinin aynısıdır.
            //Sadece yazımları farklı
            //Ekranda ViewBag Ad içinde Haydar'ı göreceğiz
            //Umut'u göremiyoruz. Çünkğ 39.satırda ViewBag'in taşıdığı Ad değişkeni yeniden set edilmiştir.
            ViewData["Soyad"] = "Yılmaz";
            //TempData
            TempData["Adiniz"] = "Umut";

            return View();
        }
    }
}