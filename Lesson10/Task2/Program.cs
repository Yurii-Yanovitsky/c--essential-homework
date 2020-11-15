using System;

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
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);

            Console.WriteLine($"Length: {myList.Length}");

            Console.Write("Elements: ");
            foreach (var item in myList)
            {
                Console.Write($" {item}");
            }

            Console.ReadLine();
        }
    }
}
