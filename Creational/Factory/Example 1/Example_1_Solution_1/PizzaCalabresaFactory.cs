namespace Example_1_Solution_1
{
    public class PizzaCalabresaFactory : PizzaFactory
    {
        public override IPizza CreatePizza()
        {
            return new PizzaCalabresa();
        }
    }
}
