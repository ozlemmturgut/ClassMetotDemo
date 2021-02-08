using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri başarıyla eklendi!!!");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Adı : " + musteri.Adi);
                Console.WriteLine("Soyadi : " + musteri.Soyadi);
                Console.WriteLine("Yaşı : " + musteri.Yas);
                Console.WriteLine("Yaşadığı Şehir : " + musteri.Sehir);
                Console.WriteLine();
            }
            
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Numaralı müşterinin bilgileri başarıyla silindi !!!");
        }
    }
}
