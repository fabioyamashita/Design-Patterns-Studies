using System;
using Example_2_Solution_Step_2.Interfaces;
using Example_2_Solution_Step_2.NY;

namespace Example_2_Solution_Step_2.Chicago
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
