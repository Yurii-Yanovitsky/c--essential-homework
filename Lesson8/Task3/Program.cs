using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter the position name: ");
            Post worker = (Post)Enum.Parse(typeof(Post), Console.ReadLine());

            Console.WriteLine("Enter the number of hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accountant accountant = new Accountant();
            bool isBonus = accountant.AskForBonus(worker, hours);

            CheckBonus(worker, isBonus);

            Console.ReadLine();
        }
        static void CheckBonus(Post worker, bool isBonus)
        {
            if (isBonus)
            {
                Console.WriteLine($"{worker}: Here is your bonus!");
            }
            else
            {
                Console.WriteLine($"{worker}: No bonuses for you!");
            }
        }
    }
}
