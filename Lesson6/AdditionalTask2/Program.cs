using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"
this is 1 string
this is 2 string
this is 3 string
this is 4 string
this is 5 string
this is 6 string
this is 7 string
this is 8 string
this is 9 string";

            var result = TextFinder.FindAllOccurances("string", text, 5);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Occurance {i + 1}: {result[i]}");
            }

            Console.ReadLine();
        }
    }
}
