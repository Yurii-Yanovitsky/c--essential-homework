using System;

namespace AdditionalTask2
{
    public static class ExtensionClass
    {
        public static void ForEach<T>(this DynamicArray<T> source, IntAction<T> del)
        {
            for (int i = 0; i < source.Length; i++)
            {
                del(source[i]);
            }
        }
        public static DynamicArray<T> Filter<T>(this DynamicArray<T> source, FilterDelegate<T> del)
        {
            DynamicArray<T> result = new DynamicArray<T>();
            for (int i = 0; i < source.Length; i++)
            {
                if (del(source[i]))
                {
                    result.Add(source[i]);
                }
            }
            return result;
        }
        public static T Accumulate<T>(this DynamicArray<T> list, BinaryExpression<T> accumulator) where T : struct, IFormattable
        {
            T sum = default;
            for (int i = 0; i < list.Length; i++)
            {
                sum = accumulator(sum, list[i]);
            }
            return sum;
        }
    }
}
