using System;

namespace Ex03CommonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int x = 25;
            int y = 5;

            result = (x + y);
            Console.WriteLine(result);

            result = (x - y);           
            Console.WriteLine(result);

            result = (x * y);           
            Console.WriteLine(result);

            result = (x / y);          
            Console.WriteLine(result);

            result = (x % y);          // remainde of division,
            Console.WriteLine(result);

            Console.WriteLine("------------------------------------");
            int value1 = 15;
            int vslue2 = 15;

            //1 
            Console.WriteLine(++value1);
            //2
            Console.WriteLine(vslue2++);
            Console.WriteLine(vslue2);

            Console.WriteLine("------------------------------------");
            bool boolResult;
            x = 10;
            y = 15;

            boolResult = (x == y);
            Console.WriteLine(boolResult);

            boolResult = (x > y);
            Console.WriteLine(boolResult);

            boolResult = (x < y);
            Console.WriteLine(boolResult);

            boolResult = (x >= y);
            Console.WriteLine(boolResult);

            boolResult = (x <= y);
            Console.WriteLine(boolResult);

            boolResult = (x != y);
            Console.WriteLine(boolResult);

            Console.WriteLine("------------------------------------");
            bool a = true;
            bool b = false;

            boolResult = a && b;
            Console.WriteLine(boolResult); // AND operator

            boolResult = a || b;
            Console.WriteLine(boolResult); // OR operator

            boolResult = !a;
            Console.WriteLine(boolResult); // NOT operator

            Console.WriteLine("------------------------------------");
            x = 7;
            y = 10;
            int greaternumber = x > y ? x : y;
            Console.WriteLine(greaternumber); // is "x" greater than "y"? gives x if true and y if false

        }
    }
}
