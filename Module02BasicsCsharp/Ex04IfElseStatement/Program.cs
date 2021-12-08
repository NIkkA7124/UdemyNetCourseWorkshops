using System;

namespace Ex04IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year of birth?");
            string userinput = Console.ReadLine();

            int yearofbirth = int.Parse(userinput);

            bool isuserover18 = DateTime.Now.Date.Year - yearofbirth >18;
            if (isuserover18)

            {
                Console.WriteLine("Hello!");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday) 

            { 
                Console.WriteLine("Today is Wednesday"); 
            }

            else

            {
                Console.WriteLine("Acces denied");
            }
            Console.WriteLine("Bye");
        }
        
    }
}
