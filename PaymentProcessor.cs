using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}