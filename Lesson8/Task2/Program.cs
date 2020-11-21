using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string str = Console.ReadLine();

            Console.Write("Choose number of color (from 0 to 5): ");
            int color = int.TryParse(Console.ReadLine(), out color) ? color : 0;

            Printer.Print(str, color);

            Console.ReadLine();
        }
    }

}
