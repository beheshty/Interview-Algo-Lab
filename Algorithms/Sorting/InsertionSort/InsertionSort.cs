namespace Algorithms.Core.Sorting
{
    public static class InsertionSort
    {
        /// <summary>
        /// Sorts the input array in ascending order using Insertion Sort
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(1)
        /// </summary>
        public static void Sort(int[] array)
        {
            Console.WriteLine("Initial array: " + string.Join(", ", array));

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                Console.WriteLine($"\n---\nStep {i}: Insert {key} into the sorted part [0..{i - 1}]");

                // Shift elements of array[0..i-1] that are greater than key to one position ahead
                while (j >= 0 && array[j] > key)
                {
                    Console.WriteLine($"  {array[j]} > {key}, so shift {array[j]} to the right");
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;

                Console.WriteLine($"  Place {key} at position {j + 1}");
                Console.WriteLine("  Array now: " + string.Join(", ", array));
            }

            Console.WriteLine("\nFinal sorted array: " + string.Join(", ", array));
        }
    }
}
