using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth");
            DateTime birthYear = DateTime.TryParse(Console.ReadLine(), out DateTime result) ? result : result;
            DateTime today = DateTime.Now;
            TimeSpan left;

            DateTime birthday = new DateTime(DateTime.Now.Year, birthYear.Month, birthYear.Day);

            if (today < birthday)
            {
                
                left = birthday - DateTime.Now;
                Console.WriteLine($"Days left untill next birthday: {left.Days}");
            }
            else
            {
                birthday = new DateTime(DateTime.Now.Year + 1, 11, 30);
                left = birthday - DateTime.Now;
                Console.WriteLine($"Days left untill next birthday: {left.Days}");

            }

            Console.ReadLine();
        }
    }
}
