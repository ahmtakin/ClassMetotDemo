using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri mus1)
        {
            Console.WriteLine("Musteri Eklendi: "+mus1.Ad+" "+mus1.Soyad);
        }
        public void Sil(Musteri mus1)
        {
            Console.WriteLine("Musteri Silindi: "+ mus1.Ad+" "+mus1.Soyad);
        }
    }
}
