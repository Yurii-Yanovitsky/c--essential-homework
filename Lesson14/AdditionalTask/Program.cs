using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.GetEven((n) => n % 2 == 0);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
