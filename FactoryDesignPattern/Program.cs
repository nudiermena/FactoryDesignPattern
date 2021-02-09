using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            Creator creator = new Creator();
            IProduct product;
            for (int i = 1; i < 12; i++)
            {
                product = creator.FactoryMethod(i);
                Console.WriteLine("Avocados " + product.ShipFrom());
                Console.ReadLine();

            }
        }
    }
}
