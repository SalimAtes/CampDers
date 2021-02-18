using System;
using System.Collections.Generic;
using System.Text;

namespace OOOP3
{
    class DataBaseLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Loglandı");
        }
    }
}
