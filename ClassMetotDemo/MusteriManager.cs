using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri eklendi");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri silindi");
        }

        public void Listele(List<Musteri> musteriler)
        {
            Console.WriteLine("Müşterilerin listesi");
            Console.WriteLine("--------------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
