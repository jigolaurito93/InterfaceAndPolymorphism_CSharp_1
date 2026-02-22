using System;
namespace InterfaceAndPolymorphism_CSharp
{
    public class Bartender : IBar
    {
        private Margarita _margarita;
        private JackCoke _jackCoke;


        public void ServeDrinks()
        {
            _margarita.ServeMargarita();
            _jackCoke.ServeJackCoke();
        }

        public void ServeMargarita(Margarita margarita)
        {
            _margarita = margarita;
        }
        public void ServeJackCoke(JackCoke jackCoke)
        {
            _jackCoke = jackCoke;
        }
    }
}