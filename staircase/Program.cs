using System;

namespace staircase
{
    class Program
    {
        static void staircase(int n) {
            for(var iLoop = 0; iLoop < n; iLoop++)
            {
                Console.WriteLine(new string('#', iLoop + 1).PadLeft(n, ' '));
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
