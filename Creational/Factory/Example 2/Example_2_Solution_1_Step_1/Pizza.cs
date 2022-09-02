using System;

namespace Example_2_Solution_Step_1
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing...");
        }
        public void Bake()
        {
            Console.WriteLine("Baking...");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting...");
        }
        public void Box()
        {
            Console.WriteLine("Boxing...");
        }

    }
}
