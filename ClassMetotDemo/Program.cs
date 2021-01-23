using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistemde ekleme, silme, listeleme işlemi yapılır.");

            Musteri musteri1 = new Musteri { Ad = "Hakan", Soyad = "Ayaz", Sehir = "Ankara", Id = 1 };
            Musteri musteri2 = new Musteri { Ad = "Çağan", Soyad = "Memişoğlu", Sehir = "İstanbul", Id = 2 };

            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            manager.Delete(musteri2);

            List<Musteri> musteriListesi = new List<Musteri> { musteri1, musteri2 };
            manager.Listele(musteriListesi);



        }
    }
}
