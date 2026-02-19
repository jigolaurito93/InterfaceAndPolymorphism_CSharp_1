using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
}