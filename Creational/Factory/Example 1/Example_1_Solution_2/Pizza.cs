using System;

namespace Example_1_Solution_2
{
    public abstract class Pizza
    {
        public string Nome { get; set; }

        public Pizza(string nome)
        {
            Nome = nome;
        }

        public abstract int AssarPizza();
        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Nome}");
        }

    }
}
