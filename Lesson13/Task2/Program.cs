using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40);

            for (int i = 0; i < 30; i++)
            {
                new Thread(new Matrix(i * 2, true).Move).Start();
            }

            Console.ReadLine();
        }
    }
}
