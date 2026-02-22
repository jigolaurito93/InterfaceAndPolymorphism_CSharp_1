using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class Baker
    {
        public Cheesecake Cheesecake { get; set; }
        public Carrotcake CarrotCake { get; set; }

        public void BakePastry()
        {
            Cheesecake.Bake();
            CarrotCake.Bake();
        }
    }
}