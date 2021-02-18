using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new İhtiyacCreditManager();
            ICreditManager tasitcreditManager = new TasitCreditManager();
            ICreditManager konutCreditmanager = new KonutCreditManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
        }
    }
}
