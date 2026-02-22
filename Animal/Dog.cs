using System;
namespace InterfaceAndPolymorphism_CSharp
{
    // The Dog class implements the IAnimal interface, providing specific implementations for the Speak and Eat methods.
    public class Dog : IAnimal
    {
        // The Speak method outputs a message indicating that the dog is barking.
        public void Speak()
        {
            Console.WriteLine("The dog barks: Woof!");
        }
        // The Eat method takes a string parameter representing the food and outputs a message indicating that the dog is eating that food.
        public void Eat(string food)
        {
            Console.WriteLine($"The dog is eating {food}");
        }
    }
}