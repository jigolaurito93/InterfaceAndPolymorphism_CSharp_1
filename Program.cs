using System;
namespace InterfaceAndPolymorphism_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bulldog = new Dog();
            bulldog.Speak();
            bulldog.Eat("bone");

            Cat siamese = new Cat();
            siamese.Speak();
            siamese.Eat("fish");

            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(150.00m);

            IPaymentProcessor paypalProcessor = new PayPalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

        }
    }
}