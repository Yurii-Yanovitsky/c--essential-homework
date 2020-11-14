using System;

namespace Task3
{
    public class MyDictionary<TKey, TValue>
    {
        private const int _defultSize = 5;
        private Node<TKey, TValue>[] _dictionary;

        public MyDictionary() : this(_defultSize)
        {

        }

        public MyDictionary(int initialSize)
        {
            _dictionary = new Node<TKey, TValue>[initialSize];
        }

        public void Add(TKey key, TValue value)
        {
            int index = Math.Abs(key.GetHashCode()) % _defultSize;

            Node<TKey, TValue> newNode = new Node<TKey, TValue>(key, value);

            if (_dictionary[index] != null && !_dictionary[index].Key.Equals(key))
            {

                Node<TKey, TValue> currentNode = _dictionary[index];

                while (currentNode.NextNode != null && !currentNode.NextNode.Key.Equals(key))
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.NextNode = newNode;
            }
            else if (_dictionary[index] == null)
            {
                _dictionary[index] = newNode;
            }
            else
            {
                Console.WriteLine("The same key");
            }

        }
        public TValue this[TKey key]
        {
            get
            {
                int index = Math.Abs(key.GetHashCode()) % _defultSize;

                Node<TKey, TValue> currentNode = _dictionary[index];

                while (currentNode != null && !currentNode.Key.Equals(key))
                {
                    currentNode = currentNode.NextNode;
                }

                if (currentNode != null)
                {
                    return currentNode.Value;
                }
                else
                {
                    Console.Write("Incorrect key!");
                    return default;
                }
            }
            set
            {
                int index = Math.Abs(key.GetHashCode()) % _defultSize;

                Node<TKey, TValue> newNode = new Node<TKey, TValue>(key, value);


                if (_dictionary[index] != null && !_dictionary[index].Key.Equals(key))
                {
                    Node<TKey, TValue> currentNode = _dictionary[index];

                    while (currentNode.NextNode != null && !currentNode.Key.Equals(key))
                    {
                        currentNode = currentNode.NextNode;
                    }
                    currentNode.NextNode = newNode;
                }
                else if (_dictionary[index] == null)
                {
                    _dictionary[index] = newNode;
                }
                else
                {
                    Console.WriteLine("The same key");
                }
            }
        }
    }
}