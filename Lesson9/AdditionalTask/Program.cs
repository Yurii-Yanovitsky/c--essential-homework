using System;

namespace AdditionalTask
{
    public delegate double MyDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            MyDelegate myDelegate = (int x, int y, int z) => (double)(x + y + z) / 3;

            var result = myDelegate(a, b, c);
            Console.WriteLine($"Average: {result}");

            Console.ReadLine();
        }
    }
}
