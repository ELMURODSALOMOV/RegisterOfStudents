using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Broker.Logging
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void LogError(string userMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(userMessage);
            Console.ResetColor();
        }
    }
}
