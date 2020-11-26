using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("key1", "Monday");
            dictionary.Add("key2", "Tuesday");
            dictionary.Add("key3", "Wednesday");
            dictionary.Add("key5", "Friday");

            foreach (var dic in dictionary)
            {
                Console.WriteLine(dic);
            }
            
            IEnumerable<Entry<string, string>> dictionary1 = dictionary;
            Console.WriteLine();

            dictionary["key1"] = "Monday";
            dictionary["key4"] = "Thursday";

            foreach (var dic in dictionary1)
            {
                Console.WriteLine(dic);
            }

            Console.ReadLine();
        }
    }
}
