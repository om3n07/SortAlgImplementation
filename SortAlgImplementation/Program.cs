using System;

namespace SortAlgImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new[] {12, 22, 100, 39, 5, 93, 3, 4, 6, 0};
            
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();

            var timeStart = DateTime.Now;
            var sorted = testArray;//Sort(testArray);
            var timeEnd = DateTime.Now;

            Console.WriteLine("Time to sort: " + (timeStart - timeEnd)+"\n");

            for (var i = 0; i< sorted.Length; i++)
            {
                if (i == (sorted.Length - 1)) Console.Write(sorted[i]);
                else Console.Write(sorted[i] + ", ");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Sort your code Here
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int[] Sort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
