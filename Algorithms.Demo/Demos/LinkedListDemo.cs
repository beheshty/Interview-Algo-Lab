using Algorithms.Core.DataStructures.LinkedList;
using Algorithms.Demo.Helpers;

namespace Algorithms.Demo.Demos
{
    internal class LinkedListDemo
    {
        public void Run()
        {
            var list = new LinkedList();

            while (true)
            {
                Console.WriteLine("--- Current LinkedList State ---");
                list.Display();
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add First");
                Console.WriteLine("2. Add Last");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Back to Main Menu");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        list.AddFirst(InputHelper.GetNumber("Enter a value to add to the front: "));
                        break;
                    case "2":
                        list.AddLast(InputHelper.GetNumber("Enter a value to add to the end: "));
                        break;
                    case "3":
                        list.Remove(InputHelper.GetNumber("Enter a value to remove: "));
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
