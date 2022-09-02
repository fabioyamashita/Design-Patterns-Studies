using Example_2_Solution_Step_2.Interfaces;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Example_2_Solution_Step_2.NY
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() : base()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings = new List<string> { "Grated Reggiano Cheese" };
        }
    }
}
