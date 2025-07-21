
namespace Algorithms.Core.Searching
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            int step = 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                Console.WriteLine();
                Console.WriteLine($"Step {step++}");
                Console.WriteLine($"- Left index: {left}, Right index: {right}");
                Console.WriteLine($"- Middle index: {mid}, Middle value: {array[mid]}");

                if (array[mid] == target)
                {
                    Console.WriteLine($"Match found at index {mid}");
                    return mid;
                }
                else if (array[mid] < target)
                {
                    Console.WriteLine($"{array[mid]} is less than {target}, searching the right half");
                    left = mid + 1;
                }
                else
                {
                    Console.WriteLine($"{array[mid]} is greater than {target}, searching the left half");
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
