using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    public class MyDictionary<TKey, TValue> : IEnumerable<Entry<TKey, TValue>>
    {
        private const int DefaultSize = 16;
        private readonly int _initialSize;
        private LinkedList<Entry<TKey, TValue>>[] _buckets;

        public MyDictionary() : this(DefaultSize)
        {

        }
        public MyDictionary(int initialSize)
        {
            _initialSize = initialSize;
            _buckets = new LinkedList<Entry<TKey, TValue>>[initialSize];
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetTargetBucketIndex(key);

            if (_buckets[index] == null)
            {
                var entry = new Entry<TKey, TValue>(key, value);
                var list = new LinkedList<Entry<TKey, TValue>>();
                list.AddLast(entry);
                _buckets[index] = list;
            }
            else
            {
                var list = _buckets[index];
                bool isNewKey = !list.Any((x) => x.Key.Equals(key));
                if (isNewKey)
                {
                    var entry = new Entry<TKey, TValue>(key, value);
                    list.AddLast(entry);
                }
                else
                {
                    Console.WriteLine("ERROR: Cannot added duplicate key!");
                }
            }

        }
        public TValue this[TKey key]
        {
            get
            {
                return Get(key);
            }
            set
            {
                if (TryGet(key, out TValue _))
                {
                    SetValue(key, value);
                }
                else
                {
                    this.Add(key, value);
                }

            }
        }

        private TValue Get(TKey key)
        {
            if (TryGet(key, out TValue value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("ERROR: Value by specified key is not found!");
            }
            return default;
        }
        private bool TryGet(TKey key, out TValue value)
        {
            int targetBucket = GetTargetBucketIndex(key);
            var list = _buckets[targetBucket];

            var entry = list?.FirstOrDefault((x) => x.Key.Equals(key));
            if (entry == null)
            {
                value = default;
                return false;
            }
            else
            {
                value = entry.Value;
                return true;
            }
        }
        private void SetValue(TKey key, TValue value)
        {
            int targetBucket = GetTargetBucketIndex(key);
            var list = _buckets[targetBucket];
            list.ReplaseFirst((x) => x.Key.Equals(key), new Entry<TKey, TValue>(key, value));
        }

        private int GetTargetBucketIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode() % _initialSize);
        }

        // Реализация блока итератора для перебора MyDictionary при помощи foreach
        public IEnumerator<Entry<TKey, TValue>> GetEnumerator()
        {
            foreach (var bucket in _buckets)
            {
                if (bucket != null)
                {
                    foreach (var item in bucket)
                    {
                        yield return item;
                    }
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Entry<TKey, TValue>
    {
        public Entry(TKey key, TValue value)
        {
            Value = value;
            Key = key;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public override string ToString()
        {
            return $"[{Key}], [{Value}]";
        }
    }
}
