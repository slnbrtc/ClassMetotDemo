using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi. Hoşgeldiniz," + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi. Hoşçakalın." + musteri.Ad + " " + musteri.Soyad);
        }
        

        public void MusterileriListele(Musteri[] musteri)
        {
            foreach (var musteriler in musteri)
          
                Console.WriteLine(musteriler.Id + " " + musteriler.Ad + " " + musteriler.Soyad);

            }
        }
    }
}
