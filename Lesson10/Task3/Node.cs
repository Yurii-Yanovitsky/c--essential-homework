namespace Task3
{
    public class Node<TKey, TValue>
    {
        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Node<TKey, TValue> NextNode { get; set; }

    }
}