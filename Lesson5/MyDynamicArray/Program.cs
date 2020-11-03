using System;

namespace MyDynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArrayOfString stringArray = new DynamicArrayOfString();

            for (int i = 0; i < stringArray.Size; i++)
            {
                stringArray[i] = $"String";
                Console.WriteLine($"{stringArray[i]} {i}");
            }

            stringArray.Add("End Value.");
            Console.WriteLine(stringArray[stringArray.Length - 1]);

            Console.WriteLine();

            DynamicArrayOfString stringArray2 = new DynamicArrayOfString(10);

            for (int i = 0; i < stringArray2.Size; i++)
            {
                stringArray2[i] = $"String";
                Console.WriteLine($"{stringArray2[i]} {i}");
            }

            Console.WriteLine();

            stringArray2.Add("String");
            stringArray2.Add("String");
            stringArray2.Add("String");
            stringArray2.Add("String");
            stringArray2.Add("String");
            stringArray2.Add("End Value");

            for (int i = 0; i < stringArray2.Length; i++)
            {
                Console.WriteLine($"{stringArray2[i]} {i}");
            }

            Console.WriteLine(stringArray2.Length);

            Console.ReadLine();
        }
    }

}
