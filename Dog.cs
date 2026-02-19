using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The dog barks: Woof!");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The dog is eating {food}");
        }
    }
}