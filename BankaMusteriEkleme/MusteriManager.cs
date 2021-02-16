using System;
using System.Collections.Generic;
using System.Text;

namespace BankaMusteriEkleme
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi :" + musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriHesapNo + " " + musteri.HesapSube + "/n");


        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi :" + musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriHesapNo + " " + musteri.HesapSube + "/n");

        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelendi :" + musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriHesapNo + " " + musteri.HesapSube + "/n");

        }
    }
}