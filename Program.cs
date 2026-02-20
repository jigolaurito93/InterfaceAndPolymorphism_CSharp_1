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

        }
    }
}