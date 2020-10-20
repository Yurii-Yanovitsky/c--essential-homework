using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rectangle sides:");
            Console.Write("side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Area: {rectangle.Area}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

            Console.ReadLine();
        }
    }
}
