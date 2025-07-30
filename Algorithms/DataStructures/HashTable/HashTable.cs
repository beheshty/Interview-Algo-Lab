
namespace Algorithms.Core.DataStructures.HashTable
{
    public class HashTable
    {
        private readonly HashNode?[] _buckets;

        /// <summary>
        /// The current number of key-value pairs in the hash table.
        /// </summary>
        public int Count { get; private set; }

        public HashTable(int size = 16)
        {
            _buckets = new HashNode[size];
            Count = 0;
        }

        /// <summary>
        /// Computes the bucket index for a given key.
        /// </summary>
        private int GetBucketIndex(string key)
        {
            int hashCode = key.GetHashCode();
            // Use Math.Abs to handle negative hash codes and modulo to fit within the array size.
            int index = Math.Abs(hashCode % _buckets.Length);
            Console.WriteLine($"Hashed key '{key}' to index {index}.");
            return index;
        }

        /// <summary>
        /// Adds a new key-value pair to the hash table or updates the value if the key already exists.
        /// </summary>
        public void Add(string key, int value)
        {
            int index = GetBucketIndex(key);
            HashNode? head = _buckets[index];

            // Traverse the linked list at the bucket to see if the key already exists.
            HashNode? current = head;
            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    Console.WriteLine($"Key '{key}' already exists. Updating value from {current.Value} to {value}.");
                    current.Value = value; // Update existing value
                    return;
                }
                current = current.Next;
            }

            // If the key doesn't exist, create a new node and add it to the front of the list.
            Console.WriteLine($"Key '{key}' not found. Adding new node with value {value}.");
            HashNode newNode = new HashNode(key, value);
            newNode.Next = head;
            _buckets[index] = newNode;
            Count++;
        }

        /// <summary>
        /// Retrieves the value associated with the specified key.
        /// </summary>
        /// <returns>The value associated with the key.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the key is not found.</exception>
        public int Get(string key)
        {
            int index = GetBucketIndex(key);
            HashNode? current = _buckets[index];

            // Search for the key in the linked list at the computed index.
            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    Console.WriteLine($"Found key '{key}' with value {current.Value}.");
                    return current.Value;
                }
                current = current.Next;
            }

            throw new KeyNotFoundException($"The key '{key}' was not found in the hash table.");
        }

        /// <summary>
        /// Removes the key-value pair with the specified key.
        /// </summary>
        /// <returns>True if the element is successfully removed; otherwise, false.</returns>
        public bool Remove(string key)
        {
            int index = GetBucketIndex(key);
            HashNode? current = _buckets[index];
            HashNode? prev = null;

            // Find the node with the matching key.
            while (current != null && !current.Key.Equals(key))
            {
                prev = current;
                current = current.Next;
            }

            // If the key was not found.
            if (current == null)
            {
                Console.WriteLine($"Key '{key}' not found. Nothing to remove.");
                return false;
            }

            // Unlink the node from the list.
            if (prev == null)
            {
                // The node to remove is the head of the list for this bucket.
                _buckets[index] = current.Next;
            }
            else
            {
                prev.Next = current.Next;
            }

            Count--;
            Console.WriteLine($"Successfully removed key '{key}'.");
            return true;
        }

        /// <summary>
        /// Displays the contents of the hash table, showing buckets and any chained nodes.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("\n--- Hash Table Contents ---");
            for (int i = 0; i < _buckets.Length; i++)
            {
                Console.Write($"Bucket {i}: ");
                HashNode? current = _buckets[i];
                if (current == null)
                {
                    Console.WriteLine("-> Empty");
                    continue;
                }

                while (current != null)
                {
                    Console.Write($"-> ['{current.Key}': {current.Value}] ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------\n");
        }
    }
}
