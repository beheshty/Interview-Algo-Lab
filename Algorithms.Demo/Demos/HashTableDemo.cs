using Algorithms.Core.DataStructures.HashTable;
using Algorithms.Demo.Helpers;

namespace Algorithms.Demo.Demos
{
    public static class HashTableDemo
    {
        public static void Run()
        {
            // A smaller size makes it easier to see collisions for the demo
            HashTable table = new HashTable(8);

            while (true)
            {
                table.Display();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add / Update (by Key)");
                Console.WriteLine("2. Get (by Key)");
                Console.WriteLine("3. Remove (by Key)");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine() ?? "";

                try
                {
                    switch (choice)
                    {
                        case "1":
                            string keyAdd = InputHelper.GetString("Enter a string key to add/update: ");
                            int valAdd = InputHelper.GetNumber("Enter an integer value: ");
                            table.Add(keyAdd, valAdd);
                            break;
                        case "2":
                            string keyGet = InputHelper.GetString("Enter a key to get its value: ");
                            table.Get(keyGet); // The method itself prints the result
                            break;
                        case "3":
                            string keyRemove = InputHelper.GetString("Enter a key to remove: ");
                            bool removed = table.Remove(keyRemove);
                            if (!removed) Console.WriteLine("-> Removal failed or key not found.");
                            break;
                        case "4":
                            return; // Exit to main menu
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (KeyNotFoundException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine();
            }
        }
    }
}
