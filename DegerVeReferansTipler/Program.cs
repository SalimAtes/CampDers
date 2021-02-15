using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            sayi1 = 10;
            //sayi1 ?? (30)
            //nedeni (değer tip(stack'de gerçekleşir) oldugu için) : sayi1 in değeri = sayi2 olarak alınır ve sayi2 nin değeri sayi1'e atanır sonra sayi2'ye 65 in atanması sayı1'i etkilemez


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100,200,300};
            sayilar2[0] = 999;
            //sayilar1[0] ??(999)
            //nedeni : int[] sayilar1 stack'de tutulur fakat "new dediğinde sayilar1 için heapde bi alan oluşturur ve [10,20,30] bunun bi adres değeri oluşur (örn:101) sayilar1 in adresi 101 olarak belirtilen değerde oluşur sayilar2 de aynı sekil (örn : 102) "new demek heap de yeni bir yer olustur demek" 
            // sayilar1(101) in referans numarası sayilar2(102) nin referans numarası böylece sayilar1 i sayilar2 ye eşitlediği için ikiside [100,200,300 ]olur ve sayilar2[0]=999 oldugu için sayilar1[0]=999 olur
            



            //int,dec,mal,float,double,bool(0,1) = değer tip
            //array,class,interface = referans tip
        }
    }
}
