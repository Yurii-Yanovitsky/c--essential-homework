using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value1");
            dictionary.Add("key3", "value3");
            dictionary.Add("key5", "value5");

            foreach (var dic in dictionary)
            {
                Console.WriteLine(dic);
            }

            Console.WriteLine();

            dictionary["key1"] = "value5";
            dictionary["key4"] = "value4";

            foreach (var dic in dictionary)
            {
                Console.WriteLine(dic);
            }

            Console.ReadLine();
        }
    }
}
