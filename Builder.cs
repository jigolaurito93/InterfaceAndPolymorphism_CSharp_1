using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;
        public Builder()
        {
            // The Builder class has a dependency on the Hammer and Saw classes, as it relies on them to perform its functionality of building a house.
            _hammer = new Hammer(); // 
            _saw = new Saw();
        }
        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House Built!");
        }
    }
}