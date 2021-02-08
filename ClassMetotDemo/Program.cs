using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Eren";
            musteri1.Soyadi = "Gürbüz";
            musteri1.Yas = 25;
            musteri1.Sehir = "Ankara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Deren";
            musteri2.Soyadi = "Gürbüz";
            musteri2.Yas = 20;
            musteri2.Sehir = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Özlem";
            musteri3.Soyadi = "Turgut";
            musteri3.Yas = 21;
            musteri3.Sehir = "Ankara";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Nur";
            musteri4.Soyadi = "Çelik";
            musteri4.Yas = 21;
            musteri4.Sehir = "İzmir";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Kerim";
            musteri5.Soyadi = "Aksoy";
            musteri5.Yas = 30;
            musteri5.Sehir = "İstanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);
            Console.WriteLine();

            musteriManager.MusteriListele(musteriler);
            Console.WriteLine();

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);
            musteriManager.MusteriSil(musteri5);



        }
    }
}
