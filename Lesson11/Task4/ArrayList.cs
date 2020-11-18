using System.Collections;

namespace Task4
{
    public class ArrayList : IEnumerable
    {
        private const int _defaultSize = 4;
        private int _sizeKoef = 2;
        private object[] _list;

        public ArrayList() : this(_defaultSize)
        {

        }

        public ArrayList(int capacity)
        {
            Count = 0;
            Capacity = capacity;
            _list = new object[capacity];
        }

        public int Count { get; private set; }
        public int Capacity { get; private set; }
        public object this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                if (Count > 0)
                {
                    _list[index] = value;
                }
            }
        }

        public void Add(object element)
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

        private void ResizeArray(object[] source)
        {
            object[] newArray = new object[source.Length * _sizeKoef];

            for (int i = 0; i < source.Length; i++)
            {
                newArray[i] = source[i];
            }
            _list = newArray;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _list[i];
            }
        }
    }
}
