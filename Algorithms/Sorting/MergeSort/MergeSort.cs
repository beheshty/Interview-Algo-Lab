using System.Reflection;

namespace Algorithms.Core.Sorting
{
    public static class MergeSort
    {
        /// <summary>
        /// Sorts an array of integers using the Merge Sort algorithm.
        /// This is the main entry point that initiates the recursive sorting process.
        /// </summary>
        public static void Sort(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return;
            }
            Console.WriteLine("Starting Merge Sort...");
            Sort(array, 0, array.Length - 1);
            Console.WriteLine("Merge Sort completed.");
        }

        /// <summary>
        /// Recursively divides the array into halves until each subarray has one element,
        /// then merges them back together in sorted order.
        /// </summary>
        private static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Console.WriteLine($"Dividing: Left={left}, Middle={middle}, Right={right}");

                Sort(array, left, middle);
                Sort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        /// <summary>
        /// Merges two sorted subarrays into one single sorted array.
        /// </summary>
        private static void Merge(int[] array, int left, int middle, int right)
        {
            Console.WriteLine($"\nMerging: Left={left}, Middle={middle}, Right={right}");

            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temp arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            Console.WriteLine($"Left Part:  [{string.Join(", ", leftArray)}]");
            Console.WriteLine($"Right Part: [{string.Join(", ", rightArray)}]");

            // Merge the temp arrays back into the original array
            int iLeft = 0, iRight = 0, k = left;

            while (iLeft < n1 && iRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    Console.WriteLine($"Taking {leftArray[iLeft]} from left");
                    array[k++] = leftArray[iLeft++];
                }
                else
                {
                    Console.WriteLine($"Taking {rightArray[iRight]} from right");
                    array[k++] = rightArray[iRight++];
                }
            }

            // Copy the remaining elements of leftArray
            while (iLeft < n1)
            {
                Console.WriteLine($"Copying remaining {leftArray[iLeft]} from left");
                array[k++] = leftArray[iLeft++];
            }

            // Copy the remaining elements of rightArray
            while (iRight < n2)
            {
                Console.WriteLine($"Copying remaining {rightArray[iRight]} from right");
                array[k++] = rightArray[iRight++];
            }

            Console.WriteLine($"Merged: [{string.Join(", ", array[left..(right + 1)])}]\n");
        }
    }
}

