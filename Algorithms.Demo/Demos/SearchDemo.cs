using Algorithms.Demo.Helpers;
using Algorithms.Core.Searching;

namespace Algorithms.Demo.Demos
{
    internal class SearchDemo
    {
        public void PerformBinarySearch()
        {
            int[] input = InputHelper.GetArrayInput();
            Array.Sort(input);
            Console.WriteLine("\nSorted Input for Binary Search:");
            Console.WriteLine(string.Join(", ", input));

            int target = InputHelper.GetTargetValue(input);
            int index = BinarySearch.Search(input, target);

            Console.WriteLine(index != -1
                ? $"\nTarget {target} found at index {index}."
                : $"\nTarget {target} not found.");
        }

        public void PerformLinearSearch()
        {
            int[] input = InputHelper.GetArrayInput();
            int target = InputHelper.GetTargetValue(input);
            int index = LinearSearch.Search(input, target);

            Console.WriteLine(index != -1
                ? $"\nTarget {target} found at index {index}."
                : $"\nTarget {target} not found.");
        }
    }
}
