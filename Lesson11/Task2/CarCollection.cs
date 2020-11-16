using System;
using System.Collections;

namespace Task2
{
    public class CarCollection<T> : IEnumerable
    {
        private const int defaultSize = 10;
        private T[] _parkingLot;

        public CarCollection() : this(defaultSize)
        {

        }

        public CarCollection(int initialSize)
        {
            Count = 0;
            _parkingLot = new T[initialSize];
        }

        public int Count { get; private set; }
        public int Capacity => _parkingLot.Length;
        public void Add(T car)
        {
            if (Count < Capacity)
            {
                _parkingLot[Count++] = car;
            }
            else
            {
                Console.WriteLine("Parking lot is overloaded!");
            }
        }
        public void ClearPark()
        {
            for (int i = 0; i < Count; i++)
            {
                _parkingLot[i] = default;
            }
            Count = default;
        }

        public T this[int index]
        {
            get
            {
                if (index < Count)
                {
                    return _parkingLot[index];
                }
                else
                {
                    return default;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _parkingLot[i];
            }
        }
    }
}
