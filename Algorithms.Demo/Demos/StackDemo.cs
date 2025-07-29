using Algorithms.Core.DataStructures.Stack;
using Algorithms.Demo.Helpers;

namespace Algorithms.Demo.Demos
{
    public static class StackDemo
    {
        public static void Run()
        {
            var stack = new Stack();

            while (true)
            {
                Console.WriteLine("--- Current Stack State ---");
                stack.Display();
                Console.WriteLine("---------------------------");

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Back to Main Menu");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        stack.Push(InputHelper.GetNumber("Enter a value to push: "));
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        stack.Peek();
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
