using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Solution_Step_1
{
    public class SimplePizzaFactory : ISimplePizzaFactory
    {
        // The create method is often declared static
        public Pizza CreatePizza(string type)
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

            return pizza;
        }
    }
}
