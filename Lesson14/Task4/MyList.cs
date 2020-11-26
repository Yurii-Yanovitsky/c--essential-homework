using System.Collections;
using System.Collections.Generic;

namespace Task4
{
    public class MyList<T> : IEnumerable<T>
    {
        private const int _defaultSize = 4;
        private int _sizeKoef = 2;
        private T[] _list;

        public MyList() : this(_defaultSize)
        {

        }

        public MyList(int size)
        {
            Length = 0;
            Size = size;
            _list = new T[size];
        }

        public int Length { get; private set; }
        public int Size { get; private set; }
        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                if (Length > 0) _list[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Length < Size)
            {
                _list[Length++] = element;
            }
            else
            {
                ResizeArray(_list);
                Size = _list.Length;
                this.Add(element);
            }
        }

        private void ResizeArray(T[] source)
        {
            T[] newArray = new T[source.Length * _sizeKoef];

            for (int i = 0; i < source.Length; i++)
            {
                newArray[i] = source[i];
            }
            _list = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
                        int count = 0;
            foreach (var item in _list)
            {
                if (Length > count)
                {
                    count++;
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
