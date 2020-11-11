using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask1
{
    public delegate bool FilterDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArrayOfInt arrayOfInt = new DynamicArrayOfInt(10);

            for (int i = 0; i < arrayOfInt.Size; i++)
            {
                arrayOfInt.Add(i);
            }

            var result1 = arrayOfInt.Filter(element => element % 2 == 0);
            var result2 = arrayOfInt.Filter(element => element > 5);
            var result3 = arrayOfInt.Filter(element => element % 4 == 0);

            Console.Write("result1: ");

            foreach (var item in result1)
            {
                Console.Write($" {item}");
            }

            Console.Write("\nresult2: ");

            foreach (var item in result2)
            {
                Console.Write($" {item}");
            }

            Console.Write("\nresult3: ");

            foreach (var item in result3)
            {
                Console.Write($" {item}");
            }

            Console.ReadLine();
        }
    }
}
