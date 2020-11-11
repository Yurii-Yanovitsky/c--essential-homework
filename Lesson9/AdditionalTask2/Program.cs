using System;

namespace AdditionalTask2
{
    public delegate void IntAction(int a);
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArrayOfInt arrayOfInt = new DynamicArrayOfInt(10);

            for (int i = 0; i < arrayOfInt.Size; i++)
            {
                arrayOfInt.Add(i);
            }

            Console.Write("x:");
            arrayOfInt.ForEach(x => Console.Write($" {x}"));

            Console.Write("\ny:");
            arrayOfInt.ForEach(y => Console.Write($" {y % 2}"));

            Console.Write("\nz:");
            arrayOfInt.ForEach(z => Console.Write($" {z * 5}"));

            Console.ReadLine();
        }
    }
}
