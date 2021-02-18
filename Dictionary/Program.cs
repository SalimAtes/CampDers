using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Musteri = new MyDictionary<int, string>();
            Musteri.Add(156,"salim");
            Musteri.Add(154,"ömer ");

            Musteri.Read();
        }
    }
}
