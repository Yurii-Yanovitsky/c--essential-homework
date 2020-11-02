using System;
using System.Text;

namespace AdditionalTask
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["сонце"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["pencil"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["sun"]);



            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
