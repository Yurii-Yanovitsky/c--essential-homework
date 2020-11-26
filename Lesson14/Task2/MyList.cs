using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    public class MyList<T> : IEnumerable<T>
    {
        private const int _defaultCapacity = 4;
        private int _capacityKoef = 2;
        private T[] _list;

        public MyList() : this(_defaultCapacity)
        {

        }

        public MyList(int capacity)
        {
            Count = 0;
            Capacity = capacity;
            _list = new T[capacity];
        }

        public int Count { get; private set; }
        public int Capacity { get; private set; }
        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                if (Count > 0) _list[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Count < Capacity)
            {
                _list[Count++] = element;
            }
            else
            {
                ResizeArray(_list);
                Capacity = _list.Length;
                this.Add(element);
            }
        }

        private void ResizeArray(T[] source)
        {
            T[] newArray = new T[source.Length * _capacityKoef];

            for (int i = 0; i < source.Length; i++)
            {
                newArray[i] = source[i];
            }
            _list = newArray;
        }

        // Реализация блока итератора для перебора элементов коллекции при помощи foreach
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
