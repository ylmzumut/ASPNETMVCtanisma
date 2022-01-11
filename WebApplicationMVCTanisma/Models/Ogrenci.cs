using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVCTanisma.Models
{
    public class Ogrenci : IEquatable<Ogrenci>
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public static List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>();
        public static List<Ogrenci> OgrencileriGetir()
        {
            if (OgrenciListesi.Count == 0)
            {
                OgrenciListesi = new List<Ogrenci>()
                {
                    new Ogrenci(){Id=1,Ad="Umut",Soyad="Yılmaz",DogumTarihi=new DateTime(1996,09,16)},
                    new Ogrenci(){Id=2,Ad="Berkan",Soyad="Çalasın",DogumTarihi=new DateTime(1997,08,13)},
                    new Ogrenci(){Id=3,Ad="Gökhan",Soyad="Oral",DogumTarihi=new DateTime(1997,08,11)}
                };
            }


            return OgrenciListesi;
            ;
        }
        public bool Equals(Ogrenci other)
        {
            return Id == other.Id;
        }
    }
}