using System;

namespace OOOP3
{
    class FileBaseLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
