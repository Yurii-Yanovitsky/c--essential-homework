using System;
using System.Collections;

namespace AdditionalTask3
{
    public class DynamicArrayOfInt : IEnumerable
    {
        private const int _defaultSize = 4;
        private int[] _intArray;

        public DynamicArrayOfInt() : this(_defaultSize)
        {
        }

        public DynamicArrayOfInt(int initialSize)
        {
            Length = 0;
            Size = initialSize;
            _intArray = new int[initialSize];
        }

        public int Size { get; private set; }
        public int Length { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index < _intArray.Length)
                {
                    return _intArray[index];
                }
                else
                {
                    Console.WriteLine("Index is out of range");
                    return 0;
                }
            }
            set
            {
                if (index < _intArray.Length)
                {
                    _intArray[index] = value;
                }
                else
                {
                    Console.WriteLine("Index is out of range!");
                }
            }
        }

        public void Add(int number)
        {
            if (Size > Length)
            {
                _intArray[Length++] = number;
            }
            else
            {
                _intArray = ResizeArray();
                Size = _intArray.Length;
                this.Add(number);
            }
        }
        private int[] ResizeArray()
        {
            int[] newSimpleArray = new int[_intArray.Length * 2];

            for (int i = 0; i < _intArray.Length; i++)
            {
                newSimpleArray[i] = _intArray[i];
            }
            return newSimpleArray;
        }

        public IEnumerator GetEnumerator()
        {
           return _intArray.GetEnumerator();
        }
    }
}
