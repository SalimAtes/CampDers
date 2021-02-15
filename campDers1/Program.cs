using System;

namespace campDers1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // don't repeat youself
            string kategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000; // tam sayı
            double faizOrani = 1.58; //ondalıklı sayı
            bool sistemeGirisYapmisMi = true; //giriş yapıp yapmama olayı kodlama.io ornek
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu Göster");
            }
            else
            {
                Console.WriteLine("eşittir");
            }
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
          

        }
    }
}
