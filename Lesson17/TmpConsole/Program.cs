using System;
using System.Collections.Generic;

namespace TmpConsole
{
    class Base { }

    class A : Base { }

    class B : Base { }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Base>()
            {
                new A(),
                new B(),
                new A()
            };

            //1) Без использования dynamic
            foreach (var item in list)
            {
                PrintType1(item);
            }

            Console.WriteLine("\nUse dynamic:");

            //2) С использованием dynamic
            foreach (dynamic item in list)
            {
                PrintType2(item);
            }

            Console.ReadLine();
        }

        private static void PrintType1<T>(T item)
        {
            Console.WriteLine(item.GetType());
        }

        private static void PrintType2<T>(T item)
        {
            Console.WriteLine(typeof(T));
        }
    }
}
