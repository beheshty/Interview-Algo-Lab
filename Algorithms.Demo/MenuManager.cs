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
        private readonly SortDemo sortDemo = new();
        private readonly SearchDemo searchDemo = new();
        private readonly LinkedListDemo linkedListDemo = new();
        private readonly StackDemo stackDemo = new();

        public void Start()
        {
            while (true)
            {
                PrintMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": sortDemo.ExecuteBubbleSort(); break;
                    case "2": sortDemo.ExecuteInsertionSort(); break;
                    case "3": sortDemo.ExecuteMergeSort(); break;
                    case "4": sortDemo.ExecuteQuickSort(); break;
                    case "5": searchDemo.PerformBinarySearch(); break;
                    case "6": searchDemo.PerformLinearSearch(); break;
                    case "7": linkedListDemo.Run(); break;
                    case "8": stackDemo.Run(); break;
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
            Console.WriteLine("\n0. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
