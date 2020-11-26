using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);

            IEnumerable<int> enumerable = myList;
            Console.WriteLine($"Length: {enumerable.Count()}");

            Console.Write("Elements: ");
            foreach (var item in enumerable)
            {
                Console.Write($" {item}");
            }

            Console.ReadLine();
        }
    }
}
