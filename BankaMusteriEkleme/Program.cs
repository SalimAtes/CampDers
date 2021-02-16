using System;

namespace BankaMusteriEkleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "ahmet";
            musteri1.MusteriHesapNo = "456123";
            musteri1.HesapSube = "Sultangazi";

            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Ömer";
            musteri2.MusteriHesapNo = "456124";
            musteri2.HesapSube = "Kağıthane";

            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Salim";
            musteri3.MusteriHesapNo = "456125";
            musteri3.HesapSube = "Sultanhamam";

            Musteri musteri4 = new Musteri();

            musteri4.MusteriId = 4;
            musteri4.MusteriAdi = "Kadir";
            musteri4.MusteriHesapNo = "456545";
            musteri4.HesapSube = "Fatih";

           

            MusteriManager musterimanger = new MusteriManager();
            musterimanger.MusteriEkle(musteri1);
            musterimanger.MusteriEkle(musteri2);
            musterimanger.MusteriEkle(musteri3);
            musterimanger.MusteriEkle(musteri4);
            Console.WriteLine("****************");
            musterimanger.MusteriSilme(musteri3);
            Console.WriteLine("*****************");
            musterimanger.MusteriListeleme(musteri1);
            musterimanger.MusteriListeleme(musteri2);
            musterimanger.MusteriListeleme(musteri4);
            Console.WriteLine("******************");




        }
    }
}
