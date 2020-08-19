using System;

namespace generalizedGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 20, 5, 25, 80, 90 };

            Console.WriteLine(GCD.generalizedGCD(5, arr));

        }
        
    }
}
