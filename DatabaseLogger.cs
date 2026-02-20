using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class DatabaseLogger : ILogger
    {
        public void LogMessage(string message)
        {   
            // Implementing the logic to log a message to a database. For demonstration purposes, we will just print the message to the console.
            Console.WriteLine($"Logging to Database: {message}");
        }
    }
}