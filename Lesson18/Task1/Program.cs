using System;
using Collections;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dic = new MyDictionary<string, string>();

            dic.Add("one", "Monday");
            dic.Add("two", "Tuesday");
            dic.Add("three", "Wednesday");
            dic.Add("four", "Thursday");
            dic.Add("five", "Friday");
            dic.Add("six", "Suturday");
            dic.Add("seven", "Sunday");

            dic["seven"] = "Day-Off";

            foreach (var d in dic)
            {
                Console.WriteLine(d);
            }



            Console.ReadLine();
        }
    }
}
