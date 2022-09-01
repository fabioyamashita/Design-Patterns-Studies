namespace Example_1_Solution_1
{
    public class PizzaMussarelaFactory : PizzaFactory
    {
        public override IPizza CreatePizza()
        {
            return new PizzaMussarela();
        }
    }
}
