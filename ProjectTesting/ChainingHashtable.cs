using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public class ChainingHashtable<TKey, TValue>
    {
        private class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Next { get; set; }

            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private Node[] table;
        private int count;

        public ChainingHashtable(int capacity)
        {
            table = new Node[capacity];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetIndex(key);
            Node node = new Node(key, value);
            node.Next = table[index];
            table[index] = node;
            count++;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            int index = GetIndex(key);
            for (Node node = table[index]; node != null; node = node.Next)
            {
                if (node.Key.Equals(key))
                {
                    value = node.Value;
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }

        private int GetIndex(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % table.Length;
        }
    }
}
