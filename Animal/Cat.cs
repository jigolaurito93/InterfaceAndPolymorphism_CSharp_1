using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The cat meows: Meow!");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}");
        }
    }
}