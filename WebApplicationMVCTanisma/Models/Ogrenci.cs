using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVCTanisma.Models
{
    public class Ogrenci : IEquatable<Ogrenci>
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Öğrenci adı boş geçilemez!")]
        [StringLength(maximumLength:25,MinimumLength =2,ErrorMessage ="Adınız 2 ile 25 karakter aralığında olmalıdır!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Öğrenci soyadı boş geçilemez!")]
        [StringLength(maximumLength: 25, MinimumLength = 2, ErrorMessage = "Soyadınız 2 ile 25 karakter aralığında olmalıdır!")]
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
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