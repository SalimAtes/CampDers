using System;

namespace odev1Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler Musteri1 = new Musteriler();
            Musteri1.musteriAdi = "ali";
            Musteri1.musteriSoyadi = "toptaş";
            Musteri1.cinsiyet = "erkek";
            Musteri1.dogumYılı = 1888;
            Musteri1.sehir = "sivas";

            Musteriler Musteri2 = new Musteriler();
            Musteri2.musteriAdi = "veli";
            Musteri2.musteriSoyadi = "taş";
            Musteri2.cinsiyet = "erkek";
            Musteri2.dogumYılı = 1958;
            Musteri2.sehir = "sivas";

            Musteriler Musteri3 = new Musteriler();
            Musteri3.musteriAdi = "berat";
            Musteri3.musteriSoyadi = "top";
            Musteri3.cinsiyet = "erkek";
            Musteri3.dogumYılı = 1985;
            Musteri3.sehir = "erzincan";

            Musteriler Musteri4 = new Musteriler();
            Musteri4.musteriAdi = "sayit";
            Musteri4.musteriSoyadi = "sezen";
            Musteri4.cinsiyet = "erkek";
            Musteri4.dogumYılı = 1996;
            Musteri4.sehir = "malatya";

            Musteriler Musteri5 = new Musteriler();
            Musteri5.musteriAdi = "aslı";
            Musteri5.musteriSoyadi = "toptaş";
            Musteri5.cinsiyet = "kadın";
            Musteri5.dogumYılı = 1999;
            Musteri5.sehir = "istanbul";

            Musteriler Musteri6 = new Musteriler();
            Musteri6.musteriAdi = "mete";
            Musteri6.musteriSoyadi = "mete";
            Musteri6.cinsiyet = "erkek";
            Musteri6.dogumYılı = 1998;
            Musteri6.sehir = "malatya";

            Musteriler Musteri7 = new Musteriler();
            Musteri7.musteriAdi = "semi";
            Musteri7.musteriSoyadi = "toptaş";
            Musteri7.cinsiyet = "erkek";
            Musteri7.dogumYılı = 1996;
            Musteri7.sehir = "sivas";

            Musteriler[] bilgiler = new Musteriler[] {Musteri1, Musteri2, Musteri3, Musteri4, Musteri5, Musteri6, Musteri7 };

            if ()
            {
                foreach (var Musteriler in bilgiler)

                {

                    Console.WriteLine(Musteriler.musteriAdi + " " + Musteriler.musteriSoyadi + " " + Musteriler.dogumYılı + " " + Musteriler.sehir + " " + Musteriler.cinsiyet);

                }
            }
            
            
        }
        class Musteriler
        {
            public string musteriAdi { get; set; }
            public string musteriSoyadi { get; set; }
            public string cinsiyet { get; set; }
            public int dogumYılı { get; set; }
            public string sehir { get; set; }
        }
    }
}
