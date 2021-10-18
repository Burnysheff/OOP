using System;
using System.IO;
namespace OOP
{
    public class FileLogWriter: ILogWriter
    {
        public void LogInfo(string message)
        {
            using (StreamWriter logs = new StreamWriter($"1.txt", true))
            {
                DateTime thisDay = DateTime.Now;
                logs.WriteLine(thisDay + "+0000/tInfo/t" + message);
            }
        }
        public void LogWarning(string message)
        {
            using (StreamWriter logs = new StreamWriter($"1.txt", true))
            {
                DateTime thisDay = DateTime.Now;
                logs.WriteLine(thisDay + "+0000/tWarning/t" + message);
            }
        }
        public void LogError(string message)
        {
            using (StreamWriter logs = new StreamWriter($"1.txt", true))
            {
                DateTime thisDay = DateTime.Now;
                logs.WriteLine(thisDay + "+0000/tError/t" + message);
            }
        }
    }
}
