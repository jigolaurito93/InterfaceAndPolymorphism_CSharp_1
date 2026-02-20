using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }
        public void GetLogger()
        {
            _logger.LogMessage("Starting to log messages using the provided logger.");
            _logger.LogMessage("Done with logging messages using the provided logger.");
        }
    }
}