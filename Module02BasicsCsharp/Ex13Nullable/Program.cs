using System;

namespace Ex13Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> favouritenumber = 256;

            Console.WriteLine("Favourite number: " + (favouritenumber != null ? favouritenumber.ToString() : ""));
        }
    }
}
