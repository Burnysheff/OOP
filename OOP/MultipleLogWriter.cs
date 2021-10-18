using System;
using System.Collections.Generic;
namespace OOP
{
    public class MultipleLogWriter : ILogWriter
    {
        private static List<ILogWriter> listOfLogs = new List<ILogWriter>();
        public MultipleLogWriter(List<ILogWriter> list)
        {
            listOfLogs = list;
        }
        public void LogInfo(string message)
        {
            foreach (ILogWriter log in listOfLogs)
            {
                log.LogInfo(message);
            }
        }
        public void LogWarning(string message)
        {
            foreach (ILogWriter log in listOfLogs)
            {
                log.LogInfo(message);
            }
        }
        public void LogError(string message)
        {
            foreach (ILogWriter log in listOfLogs)
            {
                log.LogInfo(message);
            }
        }
    }
}
