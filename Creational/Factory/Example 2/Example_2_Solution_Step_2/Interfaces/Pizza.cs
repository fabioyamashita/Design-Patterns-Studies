using System;
using System.Collections.Generic;

namespace Example_2_Solution_Step_2.Interfaces
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { private get; set; }
        public string Sauce { private get; set; }
        public List<string> Toppings { private get; set; }

        public virtual void Prepare()
        {
            Console.WriteLine($"\nPreparing {Name}");
            Console.WriteLine($"Tossing dough ({Dough})...");
            Console.WriteLine($"Adding sauce ({Sauce})...");
            Console.Write($"Adding Toppings: ");
            foreach(var toppings in Toppings)
            {
                Console.Write(toppings + "..");
            }

        }
        public virtual void Bake()
        {
            Console.WriteLine("\nBake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }
}
