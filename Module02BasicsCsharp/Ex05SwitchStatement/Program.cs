using System;

namespace Ex05SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monady :(");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;       

                case DayOfWeek.Friday:
                    Console.WriteLine("The last day od the work week! :)");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's weekend! :)");
                    break;

                default:
                    Console.WriteLine("It's a middle of the work week");
                    break;

             
            }

            }
        }
}
