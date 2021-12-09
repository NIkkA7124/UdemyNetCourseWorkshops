using System;

namespace Ex11ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "Mazda", "BMW" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
              if (car =="BMW")
              {
                  Console.WriteLine("Bye");
                  break; } 
                        
                                              
             }
        }
    }
}
