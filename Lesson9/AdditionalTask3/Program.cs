using System;

namespace AdditionalTask3
{
    public delegate double BinaryExpression(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArrayOfInt arrayOfInt = new DynamicArrayOfInt(10);

            for (int i = 0; i < arrayOfInt.Size; i++)
            {
                arrayOfInt.Add(i);
            }

            var result = arrayOfInt.Accumulate((sum, x) => sum + x);
            Console.WriteLine($"Result: {result}");

            Console.ReadLine();
        }
    }
}
