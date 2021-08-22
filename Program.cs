using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11111;
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 22222;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Durmaz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 33333;
            musteri3.Ad = "Selin";
            musteri3.Soyad = "Yılmaz";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 44444;
            musteri4.Ad = "Serra";
            musteri4.Soyad = "Akıncı";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);

            musteriManager.MusteriSil(musteri1);

            musteriManager.MusterileriListele(musteriler);

            
        }
       
    }
}
