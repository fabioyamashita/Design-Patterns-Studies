// Using the model as reference for the solution

using System;

namespace Example_1_Solution_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaria = new Pizzaria();

            Console.WriteLine("Criando uma pizza de mussarela");
            pizzaria.DeliveryPizza(new PizzaMussarelaFactory());

            Console.WriteLine("");

            Console.WriteLine("Criando uma pizza de calabresa");
            pizzaria.DeliveryPizza(new PizzaCalabresaFactory());

        }
    }
}