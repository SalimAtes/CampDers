using System;

namespace campClass
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem varış";
            kurs2.İzlenmeOrani = 60;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.İzlenmeOrani = 80;

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
              
            {
                Console.WriteLine(kurs.KursAdi+" "+ kurs.Egitmen+" "+ kurs.İzlenmeOrani);
            }

        }
        class kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int İzlenmeOrani { get; set; }


        }
    }
}
