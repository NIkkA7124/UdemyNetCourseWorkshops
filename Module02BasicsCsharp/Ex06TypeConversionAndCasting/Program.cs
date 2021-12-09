using System;

namespace Ex06TypeConversionAndCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            int yearofBirth;  
            if (int.TryParse(userinput, out yearofBirth)) // converting method from the string type
            {
                int age = DateTime.Now.Year - yearofBirth;

                Console.WriteLine("You are " + age);
            }
            else 
            {
                Console.WriteLine("Try again");
            }

        }
    }
}
