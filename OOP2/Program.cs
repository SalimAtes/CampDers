using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //salim
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "2566";
            musteri1.Adi = "salim";
            musteri1.Soyadi = "ateş";
            musteri1.TcNo = "454489894";

            //güneysu ltd.sti.
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "256";
            musteri2.SirketAdi = "güneys";
            musteri2.VergiNo = "45465847683";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            

        }
    }
}
