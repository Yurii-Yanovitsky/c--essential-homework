namespace Task3
{
    class Node<TValue>
    {
        public Node(TValue value, Node<TValue> next)
        {
            Value = value;
            Next = next;
        }
        public TValue Value { get; set; }
        public Node<TValue> Next { get; set; }
    }
}
