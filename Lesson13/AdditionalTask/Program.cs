using System;
using System.Threading;

namespace AdditionalTask
{
    class Program
    {
        static int count = 0;
        static void MyMethod(object str)
        {
            Console.WriteLine($"Call MyMethod on thread {count}");
            Thread.Sleep(1500);
            Thread thread = new Thread(MyMethod);
            count++;
            thread.Start();
        }
        static void Main()
        {
            Thread thread = new Thread(MyMethod);
            thread.Start();
        }
    }
}
