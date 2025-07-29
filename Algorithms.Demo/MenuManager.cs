using Algorithms.Demo.Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Demo
{
    public class MenuManager
    {

        public void Start()
        {
            while (true)
            {
                PrintMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": SortDemo.ExecuteBubbleSort(); break;
                    case "2": SortDemo.ExecuteInsertionSort(); break;
                    case "3": SortDemo.ExecuteMergeSort(); break;
                    case "4": SortDemo.ExecuteQuickSort(); break;
                    case "5": SearchDemo.PerformBinarySearch(); break;
                    case "6": SearchDemo.PerformLinearSearch(); break;
                    case "7": LinkedListDemo.Run(); break;
                    case "8": StackDemo.Run(); break;
                    case "9": QueueDemo.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice.\n"); break;
                }

                Console.WriteLine("\n------\n");
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("--- Sorting Algorithms ---");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Quick Sort");
            Console.WriteLine("\n--- Searching Algorithms ---");
            Console.WriteLine("5. Binary Search");
            Console.WriteLine("6. Linear Search");
            Console.WriteLine("\n--- Data Structures ---");
            Console.WriteLine("7. LinkedList Demo");
            Console.WriteLine("8. Stack Demo");
            Console.WriteLine("9. Queue Demo");
            Console.WriteLine("\n0. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
