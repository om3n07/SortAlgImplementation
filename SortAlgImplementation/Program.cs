using System;
using System.Diagnostics;

namespace SortAlgImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new[] { 12, 22, 100, 39, 5, 93, 3, 4, 6, 0 };

            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var sorted = Sort(testArray);
            stopWatch.Stop();

            Console.WriteLine("\n\nTime to sort: " + (stopWatch.ElapsedMilliseconds) + "ms\n");

            for (var i = 0; i < sorted.Length; i++)
            {
                if (i == (sorted.Length - 1)) Console.Write(sorted[i]);
                else Console.Write(sorted[i] + ", ");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// your code Here
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int[] Sort(int[] arr)
        {
            return arr;
        }
    }
}
