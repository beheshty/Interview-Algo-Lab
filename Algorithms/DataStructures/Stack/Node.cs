namespace Algorithms.Core.DataStructures.Stack
{
    public class Node
    {
        public int Data { get; }
        public Node? Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }
}
