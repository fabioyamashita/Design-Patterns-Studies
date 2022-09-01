using System;

namespace Example_1_Solution_2
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome)
        {
        }

        public override int AssarPizza()
        {
            var tempo = 20;
            Console.WriteLine($"Assado pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}
