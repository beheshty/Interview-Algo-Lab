using Algorithms.Core.DataStructures.Queue;
using Algorithms.Demo.Helpers;

namespace Algorithms.Demo.Demos
{
    public static class QueueDemo
    {
        public static void Run()
        {
            Queue queue = new Queue();

            while (true)
            {
                Console.WriteLine("--- Current Queue State ---");
                queue.Display();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Enqueue (add to back)");
                Console.WriteLine("2. Dequeue (remove from front)");
                Console.WriteLine("3. Peek (view front)");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine() ?? "";


                switch (choice)
                {
                    case "1":
                        int valEnqueue = InputHelper.GetNumber("Enter a value to enqueue: ");
                        queue.Enqueue(valEnqueue);
                        break;
                    case "2":
                        queue.Dequeue();
                        break;
                    case "3":
                        queue.Peek();
                        break;
                    case "4":
                        return; // Exit to main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
