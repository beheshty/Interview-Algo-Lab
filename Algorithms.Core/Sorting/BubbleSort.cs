using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public static class BubbleSort
    {
        /// <summary>
        /// Sorts the input array in ascending order using Bubble Sort
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(1)
        /// </summary>
        public static void Sort(int[] arr)
        {
            Console.WriteLine("Initial array: " + string.Join(", ", arr));
            Console.WriteLine("Starting Bubble Sort...\n");
            if (arr == null || arr.Length < 2)
            {
                Console.WriteLine("The Array does not need sorting!\n");
                return;
            }

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                Console.WriteLine($"Pass {i + 1}:");
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write($"  Comparing {arr[j]} and {arr[j + 1]}");
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                        Console.WriteLine(" => swapped");
                    }
                    else 
                    {
                        Console.WriteLine(" => no change");
                    }
                }

                Console.WriteLine("  Result after pass: " + string.Join(", ", arr));
                Console.WriteLine();

                // If no two elements were swapped by inner loop, then break
                if (!swapped)
                {
                    Console.WriteLine("No swaps occurred in this pass — array is sorted.");
                    break;
                }

                Console.WriteLine("Final sorted array: " + string.Join(", ", arr));
            }
        }
    }
}
