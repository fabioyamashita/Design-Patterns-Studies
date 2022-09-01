namespace Example_1_Solution_2
{
    public class PizzaFactory
    {
        public Pizza CriarPizza(string tipo)
        {
            Pizza pizza = null;
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela("mussarela");
            }
            if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa("calabresa");
            }

            return pizza;
        }
    }
}
