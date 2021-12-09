using System;

namespace Ex12Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gender? 1 - Male, 2 - Female");
            string userinput = Console.ReadLine();

            Gender usergender = (Gender)Enum.Parse(typeof(Gender), userinput);
            if (usergender == Gender.Male)
            { Console.WriteLine("Only women are allowed");
            }
            else
            { Console.WriteLine("Hi");
            }
            }
    }
}
