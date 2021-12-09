using System;

namespace Ex10ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Mazda", "Audi", "BMW" };

            int i = 0;
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "Audi")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                i++;
            }

            Console.WriteLine("--------------------------------------------");

            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
                if (cars[j] == "Audi")
                {
                    Console.WriteLine("Bye");
                    break;
                }

            }
        }
    }
}
