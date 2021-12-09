using System;

namespace Ex09Do_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To exit, type 'x'");
            string userinput;
            do
            {
                userinput = Console.ReadLine();
                Console.WriteLine($"Echo: {userinput}");

            } while (userinput != "x");
        }
    }
}
