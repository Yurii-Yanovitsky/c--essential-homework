using System;

namespace AdditionalTask
{
    public class Printer
    {
        ConsoleColor _color;
        public Printer(ConsoleColor color)
        {
            _color = color;
        }
        public virtual void Print(string value)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
