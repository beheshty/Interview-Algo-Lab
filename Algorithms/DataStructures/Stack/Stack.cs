
namespace Algorithms.Core.DataStructures.Stack
{
    public class Stack
    {
        private Node? _top; // The top element of the stack

        /// <summary>
        /// Gets the number of elements contained in the stack.
        /// </summary>
        public int Count { get; private set; }

        public Stack()
        {
            _top = null;
            Count = 0;
        }

        /// <summary>
        /// Adds an element to the top of the stack.
        /// </summary>
        /// <param name="data">The integer to add to the stack.</param>
        public void Push(int data)
        {
            var newNode = new Node(data);
            newNode.Next = _top; // The new node points to the old top
            _top = newNode;      // The top is now the new node
            Count++;
            Console.WriteLine($"Pushed {data} onto the stack.");
        }

        /// <summary>
        /// Removes and returns the element at the top of the stack.
        /// </summary>
        /// <returns>The element removed from the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the stack is empty.</exception>
        public int Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack.");
            }

            int data = _top.Data; // Get the data from the top element
            _top = _top.Next;     // Move the top pointer to the next element
            Count--;

            Console.WriteLine($"Popped {data} from the stack.");
            return data;
        }

        /// <summary>
        /// Returns the element at the top of the stack without removing it.
        /// </summary>
        /// <returns>The element at the top of the stack.</returns>
        public int Peek()
        {
            if (_top == null)
            {
                Console.WriteLine($"Cannot peek an empty stack.");
            }

            int data = _top.Data;
            Console.WriteLine($"Peeked {data} from the top of the stack.");
            return data;
        }

        /// <summary>
        /// Checks if the stack is empty.
        /// </summary>
        /// <returns>True if the stack is empty, otherwise false.</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Displays all elements in the stack from top to bottom.
        /// </summary>
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.Write("Stack (Top -> Bottom): ");
            Node? current = _top;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}

