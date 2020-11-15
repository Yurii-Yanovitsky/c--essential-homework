using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> days = new MyDictionary<string, string>();

            days.Add("one", "Monday");
            days.Add("two", "Tuesday");
            days.Add("three", "Wednesday");
            days.Add("four", "Thursday");
            days.Add("five", "Friday"); ;

            days["six"] = "Saturday";
            days["seven"] = "Sanday";

            Console.WriteLine(days["one"]);
            Console.WriteLine(days["two"]);
            Console.WriteLine(days["three"]);
            Console.WriteLine(days["four"]);
            Console.WriteLine(days["five"]);
            Console.WriteLine(days["seven"]);

            Console.ReadLine();
        }
    }
}