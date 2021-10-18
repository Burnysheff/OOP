using System;
using System.IO;
namespace OOP
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            DateTime thisDay = DateTime.Now;
            Console.WriteLine(thisDay + "+0000/tInfo/t" + message);
        }
        public void LogWarning(string message)
        {
            DateTime thisDay = DateTime.Now;
            Console.WriteLine(thisDay + "+0000/tWarning/t" + message);
        }
        public void LogError(string message)
        {
            DateTime thisDay = DateTime.Now;
            Console.WriteLine(thisDay + "+0000/tError/t" + message);
        }
    }
}
