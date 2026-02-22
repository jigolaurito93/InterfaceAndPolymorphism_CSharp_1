using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class PaymentService
    {
        // The PaymentService class depends on the IPaymentProcessor interface, allowing it to process payments without being tightly coupled to a specific payment method. 
        // This design promotes flexibility and adherence to the Dependency Inversion Principle.
        private readonly IPaymentProcessor _processor;

        // The constructor of the PaymentService class takes an IPaymentProcessor as a parameter, enabling dependency injection.
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        // The ProcessOrderPayment method uses the injected IPaymentProcessor to process the payment for an order, 
        // demonstrating polymorphism as it can work with any implementation of the IPaymentProcessor interface.
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
}