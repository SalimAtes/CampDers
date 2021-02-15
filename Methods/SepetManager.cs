using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {// naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : "+ urun.Adi + " Fiyat : "+urun.Fiyati+" Stok Adedi: "+urun.StokAdedi);

        }

        public void Ekle2(string urunadi,string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urunadi);
        }
    }
}
