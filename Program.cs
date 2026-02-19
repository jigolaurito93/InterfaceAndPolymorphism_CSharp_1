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
        }
    }
}