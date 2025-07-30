
namespace Algorithms.Core.DataStructures.HashTable
{
    public class HashNode
    {
        public string Key { get; }
        public int Value { get; set; }
        public HashNode? Next { get; set; }

        public HashNode(string key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
