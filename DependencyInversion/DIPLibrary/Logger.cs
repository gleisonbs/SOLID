using System;

namespace DIPLibrary
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }
}