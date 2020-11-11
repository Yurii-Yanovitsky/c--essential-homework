using System;

namespace Task2
{
    public delegate void MyDelegate(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;

            Console.Write("Enter the first number: ");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = int.Parse(Console.ReadLine());

            Console.Write("Choose action ( +, - , * , / ): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    myDelegate += (x, y) => { Console.WriteLine(x + y); };
                    break;
                case "-":
                    myDelegate += (x, y) => { Console.WriteLine(x - y); };
                    break;
                case "*":
                    myDelegate += (x, y) => { Console.WriteLine(x * y); };
                    break;
                case "/":
                    myDelegate += (x, y) =>
                    {
                        if (y == 0)
                            Console.WriteLine("Cannot be divide by zero");
                        else
                            Console.WriteLine(x / y);
                    };
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            myDelegate?.Invoke(a, b);

            Console.ReadLine();
        }

    }
}
