using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> days = new MyList<string>();

            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sanday");

            var resultDays = days.GetArray();

            Console.WriteLine(resultDays.GetType().Name);

            Console.WriteLine();

            foreach (var day in resultDays)
            {
                Console.WriteLine(day);
            }

            Console.ReadLine();

        }
    }
}
