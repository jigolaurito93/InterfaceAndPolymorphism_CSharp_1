using System;
namespace InterfaceAndPolymorphism_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dog bulldog = new Dog();
            bulldog.Speak();
            bulldog.Eat("bone");

            Cat siamese = new Cat();
            siamese.Speak();
            siamese.Eat("fish");
            */

            // Demonstrating polymorphism with the PaymentService and IPaymentProcessor interface

            // We create an instance of CreditCardProcessor that has a method called ProcessPayment()
            // which takes a decimal amount and prints a message.
            // We use IPaymentProcessor interface as a reference type.
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();

            // We create an instance of PaymentService class that takes an IPaymentProcessor type in its constructor.
            // We passed the creditCardProcessor instance/object to the PaymentService as an argument.
            PaymentService paymentService = new PaymentService(creditCardProcessor);

            // We call the ProcessOrderPayment method from the PaymentService class, 
            // which internally calls the ProcessPayment method of the CreditCardProcessor instance.
            paymentService.ProcessOrderPayment(150.00m);

            // We create an instance of PayPalProcessor that also implements the IPaymentProcessor interface and has its own implementation of the ProcessPayment() method
            // which takes a decimal amount and prints a message specific to PayPal payments.
            IPaymentProcessor paypalProcessor = new PayPalProcessor();

            // We create another instance of PaymentService class, but this time we pass the paypalProcessor instance/object to it.
            paymentService = new PaymentService(paypalProcessor);

            // We call the ProcessOrderPayment method again, but now it will call the ProcessPayment method of the PayPalProcessor instance, demonstrating polymorphism.
            paymentService.ProcessOrderPayment(200.00m);

            // Using the File class, we can write a long message to a log file called "log.txt".
            // The AppendAllText method will create the file if it doesn't exist, or append to it if it does.
            // The first argument is the file name, and the second argument is the message we want to write, followed by a newline character for better readability.
            File.AppendAllText("log.txt", "Hello, this is a long message that will be written to the log file.\n");
        }
    }
}