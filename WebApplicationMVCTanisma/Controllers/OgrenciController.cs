using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCTanisma.Models;

namespace WebApplicationMVCTanisma.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()
        {
            List<Ogrenci> ogrList = Ogrenci.OgrencileriGetir();
            return View(ogrList);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Ogrenci ogr)
        {
            //Veritabanımız olmadığı için id'yi kendimiz atama amaçlı bu satırları yazdık
            var tumOgrler = Ogrenci.OgrencileriGetir();
            ogr.Id = tumOgrler.Count + 1;
            //öğrenci ekleyelim
            Ogrenci.OgrenciListesi.Add(ogr);

            //Ekleme yapıldıktan sonra Listele Action'ına redirect olalım.
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            if (id > 0)
            {
                Ogrenci bulunanOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x => x.Id == id);
                return View(bulunanOgr);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Guncelle(Ogrenci ogr)
        {
            Ogrenci guncellenecekEskiOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x => x.Id == ogr.Id);
            if (guncellenecekEskiOgr!=null)
            {
                //Öğrenciyi buldun. Bulduğun bu öğrenciye yeni değerler ata
                //guncellenecekEskiOgr.Ad=ogr.Ad;
                //=işaretinin sağında Güncelle sayfasına girdiğimiz bilgiyi aldık ve bizdeki mevcut öğrenciye atadık
                guncellenecekEskiOgr.Ad = ogr.Ad;
                guncellenecekEskiOgr.Soyad = ogr.Soyad;
                guncellenecekEskiOgr.DogumTarihi = ogr.DogumTarihi;
            }

            return RedirectToAction("Listele");
        }
    }
}