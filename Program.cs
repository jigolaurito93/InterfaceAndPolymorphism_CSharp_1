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

            // Decoupling: By using interfaces and polymorphism, we can decouple a class by depending on the interface
            // rather than the specific implementation. This means you can easily swap out different implementations of the interface 
            // without changing the code that uses it, making your code more flexible and maintainable.

            // We create an instance of FileLogger that implements the ILogger interface 
            // and has a method called LogMessage() which takes a string message and writes it to a log file.
            ILogger fileLogger = new FileLogger();
            // We create an instance of Application class that takes an ILogger type in its constructor.
            // We passed the fileLogger instance/object to the Application as an argument.
            Application app = new Application(fileLogger);
            // We call the GetLogger method from the Application class, which internally calls 
            // the LogMessage method of the FileLogger instance to log messages to a file.
            app.GetLogger();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.GetLogger();
            */

            // Dependency: A relationship between two classes where one class relies on another class to function properly.
            // In the context of interfaces and polymorphism, a class that depends on an interface is said to have a dependency on that interface. 
            // This allows for loose coupling, as the class can work with any implementation of the interface without needing to know the details of how it works.

            // The Builder class has a dependency on the Hammer and Saw classes, as it relies on them to perform its functionality of building a house.
            Builder builder1 = new Builder();
            builder1.BuildHouse();
        }
    }
}