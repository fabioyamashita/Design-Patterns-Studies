using System;

namespace Example_2_Problem
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new VeggiePizza();
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }
    }
}
