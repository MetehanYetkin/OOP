using System;

namespace OOP3
{
    class FileLoggerServices : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Logged in File");
        }
    }
}
