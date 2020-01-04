using System;
using System.Linq;

namespace minimaxsum
{
    class Program
    {
        static void miniMaxSum(long[] arr)
        {
            Array.Sort(arr);

            long min = arr.First();
            long max = arr.Last();
            long sum = arr.Sum();

            Console.WriteLine((sum - max) + " " + (sum - min));
        }

        static void Main(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));

            miniMaxSum(arr);
        }
    }
}
