using System;
using System.Collections.Generic;

namespace OOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKredisi = new İhtiyacKredisi();
            IKrediManager konutKredisi = new KonutKredisi();
            IKrediManager tasitKredisi = new TasitKredisi();

            BasvuruManager basvurumanager = new BasvuruManager();

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKredisi,konutKredisi };
            basvurumanager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
