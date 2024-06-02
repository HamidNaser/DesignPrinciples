using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesSOLID
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log {message} to file logger");
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log {message} to console logger");
        }
    }

    public class OrderProcessor
    {
        private readonly ILogger _logger;

        public OrderProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessOrder()
        {
            _logger.Log("Order processed");
        }
    }
}
