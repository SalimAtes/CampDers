using System;

namespace campDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici geliştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            //array = dizi
            string[] kurslar = new string[] { "yazılım geliştirici geliştirme kampı", "programlamaya başlangıç için temel kurs","java","python","c++" };
             
            
            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("*****for bitti*****");
            //dizileri calıstırma
            Console.WriteLine("*******************");
            Console.WriteLine("2. Sayfa");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
