using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T>
    {
        T[] sayilar;
        T[] eskiSayilar;
        public MyList()
        {
            sayilar = new T[0];
        }
        public void Add(T YeniSayilar)
        {
            T[] eskiSayilar = sayilar;
            sayilar = new T[eskiSayilar.Length + 1];
            for (int i = 0; i < eskiSayilar.Length; i++)
            {
                sayilar[i] = eskiSayilar[i];
            }
            sayilar[sayilar.Length - 1] = YeniSayilar;
        
        }

    }
}
//T[] items;
////constructor clası ı newlersem mylist çalışır (ctor)
//public MyList()
//{
//    items = new T[0];
//}
//public void Add(T item)
//{
//    T[] tempArray = items; //temparray = gecicidizi
//    items = new T[items.Length + 1];
//    for (int i = 0; i < tempArray.Length; i++)
//    {
//        items[i] = tempArray[i];
//    }

//    items[items.Length - 1] = item;

//}