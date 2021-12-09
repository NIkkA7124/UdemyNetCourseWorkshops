using System;

namespace Ex07Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "Audi", "BMW" }; // 0 1 2
            Console.WriteLine(cars[0]);
            int arraylength = cars.Length; //3

            cars[2] = "Tesla";

            Console.WriteLine(cars[cars.Length - 1]);
        }
    }
}
