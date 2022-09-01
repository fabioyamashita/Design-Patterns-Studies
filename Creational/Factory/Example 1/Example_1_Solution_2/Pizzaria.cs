namespace Example_1_Solution_2
{
    public class Pizzaria
    {
        private Pizza pizza;
        private readonly PizzaFactory _factory;

        public Pizzaria(PizzaFactory factory)
        {
            _factory = factory;
        }
        public void CriarPizza(string tipo)
        {
            pizza = _factory.CriarPizza(tipo);
            pizza.AssarPizza();
            pizza.DeliveryPizza();
        }
    }
}
