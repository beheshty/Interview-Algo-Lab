
namespace Algorithms.Core.Searching.LinearSearch
{
    public static class LinearSearch
    {
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Checking index {i}: value = {array[i]}");

                if (array[i] == target)
                {
                    Console.WriteLine($"Match found at index {i}!");
                    return i;
                }
            }

            Console.WriteLine("Target not found after checking all elements.");
            return -1;
        }
    }
}
