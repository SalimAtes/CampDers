using System;
using System.Collections.Generic;
using System.Text;

namespace OOOP3
{
    class İhtiyacKredisi : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Krediniz Hesaplandı!"); 
        }
    }
}
