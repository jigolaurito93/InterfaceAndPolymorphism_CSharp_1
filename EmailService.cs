using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message) => Console.WriteLine($"Message sent from your email: {message}");
    }
}