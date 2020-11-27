using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double a = 100;
            double b = 35;

            Console.WriteLine($"{a} + {b} = {calculator.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {calculator.Subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {calculator.Mul(a, b)}");
            Console.WriteLine($"{a} / {b} = {calculator.Divide(a, b)}");

            Console.ReadLine();
        }
    }
}
