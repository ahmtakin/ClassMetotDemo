using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager MusteriYönet = new MusteriManager();

            Musteri mus1 = new Musteri();
            mus1.Id = "1000";
            mus1.Ad = "Ahmet";
            mus1.Soyad = "Akın";
            mus1.KrediNotu = 951;
            MusteriYönet.Ekle(mus1);
            
            Musteri mus2 = new Musteri();
            mus2.Id = "2450";
            mus2.Ad = "Hasan";
            mus2.Soyad = "Bilgin";
            mus2.KrediNotu = 412;
            MusteriYönet.Ekle(mus2);

            Musteri mus3 = new Musteri();
            mus3.Id = "4485";
            mus3.Ad = "Engin";
            mus3.Soyad = "Demiroğ";
            mus3.KrediNotu = 1103;
            MusteriYönet.Ekle(mus3);

            Musteri mus4 = new Musteri();
            mus4.Id = "7546";
            mus4.Ad = "Ayda";
            mus4.Soyad = "Yeler";
            mus4.KrediNotu = 1243;
            MusteriYönet.Ekle(mus4);

            Musteri mus5 = new Musteri();
            mus5.Id = "5657";
            mus5.Ad = "Mustafa";
            mus5.Soyad = "Cengiz";
            mus5.KrediNotu = 452;
            MusteriYönet.Ekle(mus5);

            Musteri[] musteriler = new Musteri[] { mus1, mus2, mus3, mus4, mus5 };
            foreach (var musteri in musteriler)
            {
                if (musteri.KrediNotu>800)
                {
                    Console.WriteLine("Sayın " + musteri.Ad + " " + musteri.Soyad + " Kredi Alabilirsiniz... ");
                }
                else
                {
                    Console.WriteLine("Sayın " + musteri.Ad + " " + musteri.Soyad + " Maalesef Kredi Alamazsınız... ");
                    MusteriYönet.Sil(musteri);
                }
            }
            
            

        }

    }
}
