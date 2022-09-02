using System;

namespace Example_2_Solution_Step_2.Interfaces
{
    public abstract class PizzaStore
    {
        // We could make this method as sealed, if we want to enforce this
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
