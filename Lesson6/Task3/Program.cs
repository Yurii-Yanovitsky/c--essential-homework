using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 4, 2, 5, 1, 20, -8, 20, -1, 0, 10 };

            ints.Sort();

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

