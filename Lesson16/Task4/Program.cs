using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate myDate1 = new MyDate(DateTime.Now);
            MyDate myDate2 = new MyDate(new DateTime(2021, 1, 1));

            int diff = myDate2 - myDate1;

            Console.WriteLine($"Days left until 2021: {diff} days");

            MyDate newYear = myDate1 + 31;
            Console.WriteLine($"New Year date: {newYear}");

            Console.ReadLine();
        }
    }
}
