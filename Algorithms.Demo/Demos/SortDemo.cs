using Algorithms.Core.Sorting;
using Algorithms.Demo.Helpers;

namespace Algorithms.Demo.Demos
{
    public static class SortDemo
    {
        public static void ExecuteBubbleSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Bubble Sort...\n");
            BubbleSort.Sort(input);
            PrintResult(input);
        }

        public static void ExecuteInsertionSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Insertion Sort...\n");
            InsertionSort.Sort(input);
            PrintResult(input);
        }

        public static void ExecuteMergeSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Merge Sort...\n");
            MergeSort.Sort(input);
            PrintResult(input);
        }

        public static void ExecuteQuickSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Quick Sort...\n");
            QuickSort.Sort(input);
            PrintResult(input);
        }

        private static void PrintResult(int[] array)
        {
            Console.WriteLine("\nSorted Result:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
