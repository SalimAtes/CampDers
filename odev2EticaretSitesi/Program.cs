using System;

namespace odev2EticaretSitesi
{
    class Program
    {
        static void Main(string[] args)
        {
            products product1 = new products();
            product1.urun = "saat";
            product1.kategori = "takı";
            product1.indirimOrani=0.2;
            product1.fiyat = 20;

            products product2 = new products();
            product2.urun = "telefon";
            product2.kategori = "elektronik";
            product2.indirimOrani = 0.15;
            product2.fiyat = 1500;

            products product3 = new products();
            product3.urun = "çakmak";
            product3.kategori = "eşya";
            product3.indirimOrani = 0;
            product3.fiyat = 7;

            products[] product = new products[] { product1, product2, product3 };

            Console.WriteLine("*******************");
            Console.WriteLine("****For Döngüsü****");
            Console.WriteLine("*******************");

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine($"{i+1}. ürün");
                Console.WriteLine("*************");
                Console.WriteLine("Ürün Adı :"+product[i].urun);
                Console.WriteLine("Ürün Kategorisi :"+product[i].kategori);
                Console.WriteLine("İndirim Oranı :"+product[i].indirimOrani);
                Console.WriteLine("Ürün Fiyatı :"+product[i].fiyat);
                Console.WriteLine("**************");
            }

            Console.WriteLine("*******************");
            Console.WriteLine("***While Döngüsü***");
            Console.WriteLine("*******************");
            int a = 0;
            while (a < product.Length)
            {
                Console.WriteLine($"{a + 1}. ürün");
                Console.WriteLine("*************");
                Console.WriteLine("Ürün Adı :" + product[a].urun);
                Console.WriteLine("Ürün Kategorisi :" + product[a].kategori);
                Console.WriteLine("İndirim Oranı :" + product[a].indirimOrani);
                Console.WriteLine("Ürün Fiyatı :" + product[a].fiyat);
                Console.WriteLine("*******************");
                a++;
            }
            Console.WriteLine("*******************");
            Console.WriteLine("***Foreach Döngüsü***");
            Console.WriteLine("*******************");
            foreach (var products in product)
            {
                Console.WriteLine($"{a + 1}. ürün");
                Console.WriteLine("*************");
                Console.WriteLine("Ürün Adı :" + products.urun);
                Console.WriteLine("Ürün Kategorisi :" + products.kategori);
                Console.WriteLine("İndirim Oranı :" + products.indirimOrani);
                Console.WriteLine("Ürün Fiyatı :" + products.fiyat);
                Console.WriteLine("*******************");
            }


        }
        class products
        {
            public string kategori { get; set; }
            public string urun { get; set; }
            public int fiyat { get; set; }
            public double indirimOrani { get; set; }

        }
    }
}
