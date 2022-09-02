// Problem from Head First Design Patterns - Chapter 4
// It's called the Simple Factory
// It's not complete

using Example_2_Solution_Step_2.Chicago;
using Example_2_Solution_Step_2.Interfaces;
using Example_2_Solution_Step_2.NY;
using System;

namespace Example_2_Solution_Step_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();

            var ethanPizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"\nEthan ordered a {ethanPizza.Name}");

            var joelPizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"\nJoel ordered a {joelPizza.Name}");

        }
    }
}