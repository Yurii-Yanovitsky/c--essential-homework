using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class MyDictionary<TKey, TValue> : IEnumerable<Entry<TKey, TValue>>
    {
        private int _initialSize;
        private LinkedList<Entry<TKey, TValue>>[] _buckets;
        private List<int> indexHolder = new List<int>();

        public MyDictionary(int initialSize = 16)
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

                indexHolder.Add(index);
            }
            else
            {
                var list = _buckets[index];
                bool isNewKey = !list.Any((x) => x.Key.Equals(key));
                if (isNewKey)
                {
                    var entry = new Entry<TKey, TValue>(key, value);
                    list.AddLast(entry);

                    indexHolder.Add(index);
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
                    Add(key, value);
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

            var entry = list?.FirstOrDefault(x => x.Key.Equals(key));
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
            for (int i = 0; i < indexHolder.Count; i++)
            {
                int targetIndex = indexHolder[i];

                foreach (var item in _buckets[targetIndex])
                {
                    yield return item;
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
