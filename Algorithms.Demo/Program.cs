using Algorithms.Core.Searching;
using Algorithms.Core.Searching.LinearSearch;
using Algorithms.Core.Sorting;

Console.WriteLine("=== Algorithm Demo ===\n");

while (true)
{
    Console.WriteLine("Choose an algorithm:");
    Console.WriteLine("1. Bubble Sort");
    Console.WriteLine("2. Insertion Sort");
    Console.WriteLine("3. Merge Sort");
    Console.WriteLine("4. Quick Sort");
    Console.WriteLine("5. Binary Search");
    Console.WriteLine("6. Linear Search");
    Console.WriteLine("0. Exit");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            RunBubbleSort();
            break;
        case "2":
            RunInsertionSort();
            break;
        case "3":
            RunMergeSort();
            break;
        case "4":
            RunQuickSort();
            break;
        case "5":
            RunBinarySearch();
            break;
        case "6":
            RunLinearSearch();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Invalid choice.\n");
            break;
    }

    Console.WriteLine("\n------\n");
}

void RunInsertionSort()
{
    int[] input = GetInputArray();
    Console.WriteLine("\nExecuting Insertion Sort...\n");

    InsertionSort.Sort(input);

    Console.WriteLine("\nSorted Result:");
    Console.WriteLine(string.Join(", ", input));
}

static void RunBubbleSort()
{
    int[] input = GetInputArray();
    Console.WriteLine("\nExecuting Bubble Sort...\n");

    BubbleSort.Sort(input);

    Console.WriteLine("\nSorted Result:");
    Console.WriteLine(string.Join(", ", input));
}

void RunBinarySearch()
{
    int[] input = GetInputArray();
    Array.Sort(input); // Binary Search needs sorted array
    Console.WriteLine("\nSorted Input for Binary Search:");
    Console.WriteLine(string.Join(", ", input));

    int target = GetTargetValue(input);
    Console.WriteLine($"\nSearching for target: {target}\n");

    int index = BinarySearch.Search(input, target);

    if (index != -1)
        Console.WriteLine($"\nTarget {target} found at index {index}.");
    else
        Console.WriteLine($"\nTarget {target} not found.");
}

void RunLinearSearch()
{
    int[] input = GetInputArray();

    int target = GetTargetValue(input);
    Console.WriteLine($"\nSearching for target: {target}\n");

    int index = LinearSearch.Search(input, target);

    if (index != -1)
        Console.WriteLine($"\nTarget {target} found at index {index}.");
    else
        Console.WriteLine($"\nTarget {target} not found.");
}

void RunMergeSort()
{
    int[] input = GetInputArray();
    Console.WriteLine("\nExecuting Merge Sort...\n");

    MergeSort.Sort(input);

    Console.WriteLine("\nSorted Result:");
    Console.WriteLine(string.Join(", ", input));
}

void RunQuickSort()
{
    int[] input = GetInputArray();
    Console.WriteLine("\nExecuting Quick Sort...\n");

    QuickSort.Sort(input);

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

int GetTargetValue(int[] input)
{
    Console.WriteLine("\nChoose target input:");
    Console.WriteLine("1. Manual input");
    Console.WriteLine("2. Pick random value from the array");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Enter an integer to search: ");
        if (int.TryParse(Console.ReadLine(), out int manualTarget))
        {
            return manualTarget;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to first element.");
            return input[0];
        }
    }
    else
    {
        Random rand = new();
        int randomIndex = rand.Next(0, input.Length);
        int randomTarget = input[randomIndex];
        Console.WriteLine($"Random target selected: {randomTarget}");
        return randomTarget;
    }
}
