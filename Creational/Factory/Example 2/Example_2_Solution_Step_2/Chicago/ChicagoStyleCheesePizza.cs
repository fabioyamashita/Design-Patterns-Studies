using Example_2_Solution_Step_2.Interfaces;
using System;
using System.Collections.Generic;

namespace Example_2_Solution_Step_2.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() : base()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings = new List<string> { "Shredded Mozzarella Cheese" };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
