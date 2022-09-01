namespace Example_1_Solution_1
{
    public class PizzaMussarela : IPizza
    {
        public string Nome { get; set; } = "Mussarela";

        public PizzaMussarela()
        {

        }

        public int CalcularTempoAssarPizza()
        {
            return 20;
        }
    }
}
