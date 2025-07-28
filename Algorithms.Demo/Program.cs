using Algorithms.Core.DataStructures.LinkedList;
using Algorithms.Core.DataStructures.Stack;
using Algorithms.Core.Searching;
using Algorithms.Core.Sorting;

Console.WriteLine("=== Algorithm Demo ===\n");

while (true)
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
        case "7": 
            RunLinkedListDemo();
            break;
        case "8": 
            RunStackDemo();
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

void RunLinkedListDemo()
{
    LinkedList list = new LinkedList();

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
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine() ?? "";

        switch (choice)
        {
            case "1":
                int valFirst = GetNumberInput("Enter a value to add to the front: ");
                list.AddFirst(valFirst);
                break;
            case "2":
                int valLast = GetNumberInput("Enter a value to add to the end: ");
                list.AddLast(valLast);
                break;
            case "3":
                int valRemove = GetNumberInput("Enter a value to remove: ");
                list.Remove(valRemove);
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

void RunStackDemo()
{
    Stack stack = new Stack();

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
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine() ?? "";

        try
        {
            switch (choice)
            {
                case "1":
                    int valPush = GetNumberInput("Enter a value to push: ");
                    stack.Push(valPush);
                    break;
                case "2":
                    stack.Pop();
                    break;
                case "3":
                    stack.Peek();
                    break;
                case "4":
                    return; // Exit to main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine();
    }
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

int GetNumberInput(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            return value;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
