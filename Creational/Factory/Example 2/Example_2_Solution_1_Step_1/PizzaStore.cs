using System;

namespace Example_2_Solution_Step_1
{
    public class PizzaStore
    {
        private readonly ISimplePizzaFactory _factory;

        // Dependecy injection
        public PizzaStore(ISimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }
    }
}
