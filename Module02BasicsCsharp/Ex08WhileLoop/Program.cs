using System;

namespace Ex08WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Mazda", "Audi", "BMW" };

            int i = 0;
            while (i <= cars.Length - 1)
            {
                Console.WriteLine(cars[i]);
                i++;
            }
        }
    }
}
