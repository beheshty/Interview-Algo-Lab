using Algorithms.Core.Sorting;
using Algorithms.Demo.Helpers;

namespace Algorithms.Demo.Demos
{
    internal class SortDemo
    {
        public void ExecuteBubbleSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Bubble Sort...\n");
            BubbleSort.Sort(input);
            PrintResult(input);
        }

        public void ExecuteInsertionSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Insertion Sort...\n");
            InsertionSort.Sort(input);
            PrintResult(input);
        }

        public void ExecuteMergeSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Merge Sort...\n");
            MergeSort.Sort(input);
            PrintResult(input);
        }

        public void ExecuteQuickSort()
        {
            int[] input = InputHelper.GetArrayInput();
            Console.WriteLine("\nExecuting Quick Sort...\n");
            QuickSort.Sort(input);
            PrintResult(input);
        }

        private void PrintResult(int[] array)
        {
            Console.WriteLine("\nSorted Result:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
