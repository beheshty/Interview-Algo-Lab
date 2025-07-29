namespace Algorithms.Core.DataStructures.Queue
{
    public class Queue
    {
        private Node? _first; // The first element in the queue (the front)
        private Node? _last;  // The last element in the queue (the back)

        /// <summary>
        /// Gets the number of elements contained in the queue.
        /// </summary>
        public int Count { get; private set; }

        public Queue()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        /// <summary>
        /// Adds an element to the end of the queue.
        /// </summary>
        /// <param name="data">The integer to add to the queue.</param>
        public void Enqueue(int data)
        {
            var newNode = new Node(data);

            // If the queue has elements, link the current last node to the new one.
            // Otherwise, the new node is also the first node.
            if (_last != null)
            {
                _last.Next = newNode;
            }
            else
            {
                _first = newNode;
            }

            _last = newNode; // The new node is always the new last node.
            Count++;
            Console.WriteLine($"Enqueued {data} to the back of the queue.");
        }

        /// <summary>
        /// Removes and returns the element at the beginning of the queue.
        /// </summary>
        /// <returns>The element removed from the front of the queue.</returns>
        public int Dequeue()
        {
            if (_first == null)
            {
                Console.WriteLine("Cannot dequeue from an empty queue.");
            }

            int data = _first.Data; // Get the data from the first element.
            _first = _first.Next;   // Move the first pointer to the next element.

            // If the queue is now empty, the last pointer must also be null.
            if (_first == null)
            {
                _last = null;
            }

            Count--;
            Console.WriteLine($"Dequeued {data} from the front of the queue.");
            return data;
        }

        /// <summary>
        /// Returns the element at the beginning of the queue without removing it.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public int Peek()
        {
            if (_first == null)
            {
                Console.WriteLine("Cannot peek an empty queue.");
            }

            int data = _first.Data;
            Console.WriteLine($"Peeked {data} from the front of the queue.");
            return data;
        }

        /// <summary>
        /// Checks if the queue is empty.
        /// </summary>
        /// <returns>True if the queue is empty, otherwise false.</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Displays all elements in the queue from front to back.
        /// </summary>
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.Write("Queue (Front -> Back): ");
            Node? current = _first;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
