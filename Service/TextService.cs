using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class TextService : IMessageService
    {
        public void SendMessage(string message) => Console.WriteLine($"Message sent to your phone: {message}");
    }
}