

namespace Algorithms.Core.DataStructures.LinkedList
{
    public class LinkedList
    {
        public Node? Head { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Count = 0;
        }

        /// <summary>
        /// Adds a new node with the given data to the front of the list.
        /// </summary>
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head; // The new node points to the old head
            Head = newNode;      // The head is now the new node
            Count++;
            Console.WriteLine($"Added {data} to the front. New count: {Count}");
        }

        /// <summary>
        /// Adds a new node with the given data to the end of the list.
        /// </summary>
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                // Traverse to the end of the list
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
            Console.WriteLine($"Added {data} to the end. New count: {Count}");
        }

        /// <summary>
        /// Removes the first occurrence of a node with the specified data.
        /// </summary>
        /// <returns>True if the item was removed, otherwise false.</returns>
        public bool Remove(int data)
        {
            if (Head == null) return false;

            // Case 1: The node to remove is the head
            if (Head.Data == data)
            {
                Head = Head.Next;
                Count--;
                Console.WriteLine($"Removed {data} from the head. New count: {Count}");
                return true;
            }

            // Case 2: The node is somewhere else in the list
            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null) // If the node was found
            {
                current.Next = current.Next.Next; // Unlink the node
                Count--;
                Console.WriteLine($"Removed {data}. New count: {Count}");
                return true;
            }

            Console.WriteLine($"Could not find {data} to remove.");
            return false; // Node not found
        }

        /// <summary>
        /// Prints all the elements in the linked list.
        /// </summary>
        public void Display()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Console.Write("List: Head -> ");
            Node? current = Head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
