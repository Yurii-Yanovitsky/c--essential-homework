using System;

namespace Task2
{
    static class Printer
    {
        public static void Print(string str, int color)
        {
            ConsoleColor col = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),((Color)color).ToString());
            Console.ForegroundColor = col;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

}
