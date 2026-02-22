using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class UserNotification
    {
        // Create a private field to store the dependency
        private readonly IMessageService _messageService;

        // Contructor that takes in a dependency
        // Prints a message once it gets instantiated
        public UserNotification(IMessageService messageService)
        {
            _messageService = messageService;
            Console.WriteLine("Receiving a message....");
        }

        // After UserNotification gets instantiated, you can call NotifyUser method and pass in a string message as an argument.
        public void NotifyUser(string message)
        {
            _messageService.SendMessage(message);
        }


    }
}