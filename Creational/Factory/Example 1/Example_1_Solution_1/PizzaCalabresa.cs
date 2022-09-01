namespace Example_1_Solution_1
{
    public class PizzaCalabresa : IPizza
    {
        public string Nome { get; set; } = "Calabresa";
        public PizzaCalabresa()
        {

        }

        public int CalcularTempoAssarPizza()
        {
            return 30;
        }
    }
}
