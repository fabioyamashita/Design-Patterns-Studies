using System;

namespace Example_1_Solution_2
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome) : base(nome)
        {
        }

        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assado pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}
