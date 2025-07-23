
namespace Algorithms.Core.Sorting
{
    public static class QuickSort
    {
        /// <summary>
        /// Sorts an array of integers using the Quick Sort algorithm.
        /// This is the public entry point that initiates the recursive sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        public static void Sort(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return;
            }
            QuickSortRecursive(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Recursively sorts the array by partitioning it around a pivot.
        /// </summary>
        private static void QuickSortRecursive(int[] array, int low, int high)
        {
            if (low < high)
            {
                // pi is the partitioning index, array[pi] is now at the right place.
                int partitionIndex = Partition(array, low, high);

                Console.WriteLine($"\n-> Recursively sorting left side (indices {low} to {partitionIndex - 1})");
                QuickSortRecursive(array, low, partitionIndex - 1);

                Console.WriteLine($"\n-> Recursively sorting right side (indices {partitionIndex + 1} to {high})");
                QuickSortRecursive(array, partitionIndex + 1, high);
            }
            else
            {
                Console.WriteLine("  low is greater than or equal to high!");
            }
        }

        /// <summary>
        /// Partitions the array using the last element as the pivot.
        /// It places the pivot element at its correct position in the sorted array
        /// and moves all smaller elements to the left and larger elements to the right.
        /// </summary>
        /// <returns>The index of the pivot after partitioning.</returns>
        private static int Partition(int[] array, int low, int high)
        {
            // Choose the last element as the pivot
            int pivot = array[high];

            // i is the index of the smaller element, indicating the boundary
            int i = low - 1;

            Console.WriteLine($"Partitioning subarray from index {low} to {high} with pivot {pivot}");
            Console.WriteLine($"Initial state: [{string.Join(", ", array.Skip(low).Take(high - low + 1))}]");

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (array[j] <= pivot)
                {
                    i++; // Increment index of smaller element

                    if (i != j)
                    {
                        Console.WriteLine($" - Swapping {array[i]} (at index {i}) with {array[j]} (at index {j})");
                        // Swap array[i] and array[j]
                        Swap(array, i, j);
                    }
                }
            }

            // Place the pivot at its correct final position by swapping
            // it with the element at i + 1
            int pivotFinalIndex = i + 1;
            Console.WriteLine($" - Placing pivot {pivot} at its final spot by swapping with {array[pivotFinalIndex]} (at index {pivotFinalIndex})");
            Swap(array, pivotFinalIndex, high);

            Console.WriteLine($"Array after partition: [{string.Join(", ", array)}]");

            return pivotFinalIndex;
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
        }
    }
}