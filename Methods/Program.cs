using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması ";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 26;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-----------------------");
            }

            //encapsulation
            Console.WriteLine("---------METOTLAR------");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("armut", "yesil armut", 12, 10);
            sepetmanager.Ekle2("karpuz", "diyarbakır karpuzu", 25, 15);
            sepetmanager.Ekle2("elma", "yeşil elma", 14, 5);


        }
    }
}
