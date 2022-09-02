using System;
using Example_2_Solution_Step_2.Chicago;
using Example_2_Solution_Step_2.Interfaces;

namespace Example_2_Solution_Step_2.NY
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
