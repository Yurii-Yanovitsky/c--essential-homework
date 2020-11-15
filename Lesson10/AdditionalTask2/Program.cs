using System;

namespace AdditionalTask2
{
    public delegate bool FilterDelegate<T>(T a);
    public delegate void IntAction<T>(T a);
    public delegate T BinaryExpression<T>(T a, T b);
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dynamicInt = new DynamicArray<int>(10);
            for (int i = 1; i < dynamicInt.Size; i++)
            {
                dynamicInt.Add(i);
            }

            WorkWithCollections(dynamicInt);

            void WorkWithCollections(DynamicArray<int> source)
            {
                Console.WriteLine("ForEach is done");
                source.ForEach((x) => Console.Write($"{x} "));
                Console.WriteLine();

                var result1 = source.Filter((x) => x % 2 == 0);
                Console.WriteLine("Filter is done");

                foreach (var num in result1)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();

                var result2 = source.Accumulate((sum, x) => sum + x);
                Console.WriteLine("Accumulate is done");
                Console.WriteLine(result2);
            }

            Console.ReadLine();
        }
    }
}
