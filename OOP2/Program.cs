using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ömer";
            musteri1.Soyadi = "Bozlak";
            musteri1.TcNo = "13467845";
            musteri1.Id = 5;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "15648";
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "12465";

            //-----------------------------

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusterManager musteriManager = new MusterManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
