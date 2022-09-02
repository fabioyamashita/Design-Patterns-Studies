// Not ideal solution?
// PizzaFactory is not 100% correct according to OCP
// It's called the Simple Factory by Head First Design Patterns - Chapter 4

using System;

namespace Example_1_Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzaria p1 = new Pizzaria(new PizzaFactory());
            p1.CriarPizza("mussarela");
            p1.CriarPizza("calabresa");

            Console.ReadLine();
        }
    }
}