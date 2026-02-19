using System;

namespace InterfaceAndPolymorphism_CSharp
{
    // The IAnimal interface defines a contract for animal behavior, specifying that any class that implements this interface 
    // must provide implementations for the Speak and Eat methods.
    public interface IAnimal
    {
        void Speak();
        void Eat(string food);

    }
}