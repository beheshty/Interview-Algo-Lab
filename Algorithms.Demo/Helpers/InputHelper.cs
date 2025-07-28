namespace Algorithms.Demo.Helpers
{
    internal class InputHelper
    {
        public static int[] GetArrayInput()
        {
            Console.WriteLine("Choose input type:");
            Console.WriteLine("1. Manual input");
            Console.WriteLine("2. Random numbers");

            Console.Write("Enter your choice: ");
            string inputChoice = Console.ReadLine();

            return inputChoice switch
            {
                "1" => ReadManualInput(),
                "2" => GenerateRandomArray(),
                _ => GenerateRandomArray()
            };
        }

        private static int[] ReadManualInput()
        {
            Console.Write("Enter comma-separated integers: ");
            string line = Console.ReadLine();
            try
            {
                return Array.ConvertAll(line.Split(','), s => int.Parse(s.Trim()));
            }
            catch
            {
                Console.WriteLine("Invalid input. Falling back to default array.");
                return new[] { 5, 1, 4, 2, 8 };
            }
        }

        private static int[] GenerateRandomArray()
        {
            Console.Write("Enter number of elements: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
            {
                Console.WriteLine("Invalid length. Using default: 5");
                length = 5;
            }

            Random random = new();
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
                result[i] = random.Next(1, 100);

            Console.WriteLine("Generated array:");
            Console.WriteLine(string.Join(", ", result));
            return result;
        }

        public static int GetTargetValue(int[] input)
        {
            Console.WriteLine("\nChoose target input:");
            Console.WriteLine("1. Manual input");
            Console.WriteLine("2. Pick random value from the array");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter an integer to search: ");
                return int.TryParse(Console.ReadLine(), out int manualTarget)
                    ? manualTarget
                    : input[0];
            }

            Random rand = new();
            int randomTarget = input[rand.Next(0, input.Length)];
            Console.WriteLine($"Random target selected: {randomTarget}");
            return randomTarget;
        }

        public static int GetNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}
