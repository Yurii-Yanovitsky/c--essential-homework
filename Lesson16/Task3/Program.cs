using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clone()");
            House originHouse = new House("New York", new Street("Wall Street"));
            House cloneHouse = originHouse.Clone();

            Console.WriteLine("Before changing the address:");
            Console.WriteLine($"original: {originHouse}");
            Console.WriteLine($"clone: {cloneHouse}");

            cloneHouse.Street.Name = "Baker street";
            cloneHouse.City = "London";

            Console.WriteLine("After changing the address:");
            Console.WriteLine($"original: {originHouse}");
            Console.WriteLine($"clone: {cloneHouse}");

            Console.WriteLine();

            Console.WriteLine("DeepClone()");
            House originHouse1 = new House("New York", new Street("Wall Street"));
            House cloneHouse1 = originHouse1.DeepClone();

            Console.WriteLine("Before changing the address:");
            Console.WriteLine($"original: {originHouse1}");
            Console.WriteLine($"clone: {cloneHouse1}");

            cloneHouse1.Street.Name = "Baker street";
            cloneHouse1.City = "London";

            Console.WriteLine("After changing the address:");
            Console.WriteLine($"original: {originHouse1}");
            Console.WriteLine($"clone: {cloneHouse1}");

            Console.ReadLine();
        }
    }
}
