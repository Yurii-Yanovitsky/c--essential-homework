using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    class LinkedList<TValue> : IEnumerable<TValue>
    {
        private Node<TValue> _head;
        private Node<TValue> _tail;

        public LinkedList()
        {
            _head = _tail = null;
        }

        public void AddLast(TValue value)
        {
            var node = new Node<TValue>(value, null);

            if (_head == null && _tail == null)
            {
                _head = _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }
        public bool Any(Func<TValue, bool> condition)
        {
            var node = _head;
            while (node != null)
            {
                if (condition(node.Value))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }
        public TValue FirstOrDefault(Func<TValue, bool> condition)
        {
            var node = _head;
            while (node != null)
            {
                if (condition(node.Value))
                {
                    return node.Value;
                }
                node = node.Next;
            }
            return default;
        }
        public void ReplaseFirst(Func<TValue, bool> condition, TValue entry)
        {
            var node = _head;
            while (node != null)
            {
                if (condition(node.Value))
                {
                    node.Value = entry;
                }
                node = node.Next;
            }
        }


        // Реализация блока итератора для перебора бакета при помощи foreach
        public IEnumerator<TValue> GetEnumerator()
        {
            var node = _head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
