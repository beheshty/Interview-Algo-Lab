using Algorithms.Core.Sorting;

Console.WriteLine("=== Algorithm Demo ===\n");

while (true)
{
    Console.WriteLine("Choose an algorithm:");
    Console.WriteLine("1. Bubble Sort");
    Console.WriteLine("0. Exit");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            RunBubbleSort();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Invalid choice.\n");
            break;
    }

    Console.WriteLine("\n---\n");
}

static void RunBubbleSort()
{
    int[] input = GetInputArray();
    Console.WriteLine("\nExecuting Bubble Sort...\n");

    BubbleSort.Sort(input);

    Console.WriteLine("\nSorted Result:");
    Console.WriteLine(string.Join(", ", input));
}

static int[] GetInputArray()
{
    Console.WriteLine("Choose input type:");
    Console.WriteLine("1. Manual input");
    Console.WriteLine("2. Random numbers");

    Console.Write("Enter your choice: ");
    string inputChoice = Console.ReadLine();

    if (inputChoice == "1")
    {
        return ReadManualInput();
    }
    else if (inputChoice == "2")
    {
        return GenerateRandomArray();
    }
    else
    {
        Console.WriteLine("Invalid input type. Defaulting to random.");
        return GenerateRandomArray();
    }
}

static int[] ReadManualInput()
{
    Console.Write("Enter comma-separated integers: ");
    string line = Console.ReadLine();
    try
    {
        int[] result = Array.ConvertAll(line.Split(','), s => int.Parse(s.Trim()));
        return result;
    }
    catch
    {
        Console.WriteLine("Invalid input. Falling back to default array.");
        return [5, 1, 4, 2, 8];
    }
}

static int[] GenerateRandomArray()
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
        result[i] = random.Next(1, 100); // range: 1 to 99

    Console.WriteLine("Generated array:");
    Console.WriteLine(string.Join(", ", result));

    return result;
}
