using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1,2,3,4);
            Block block2 = new Block(1,2,3,4);

            Console.WriteLine($"block1: {block1}");
            Console.WriteLine($"block2: {block2}");

            bool isEual = block1.Equals(block2);
            Console.WriteLine($"block1 is equal to block2? - {isEual}");

            Console.ReadLine();
        }
    }
}
