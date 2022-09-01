using System;

namespace Example_1_Solution_1
{
    public abstract class PizzaFactory
    {
        public abstract IPizza CreatePizza();
        public void AssarPizza()
        {
            var pizza = CreatePizza();
            Console.WriteLine($"Assando pizza de {pizza.Nome} - Duração: {pizza.CalcularTempoAssarPizza()} min");
        }
    }
}
