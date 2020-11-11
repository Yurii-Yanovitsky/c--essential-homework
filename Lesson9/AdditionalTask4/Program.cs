using System;

namespace AdditionalTask4
{
    public delegate bool DivideByZeroErrorHandler(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(Handler);

            Console.WriteLine(calculator.Add(4, 8));
            Console.WriteLine(calculator.Sub(5, 9));
            Console.WriteLine(calculator.Mul(15, 78));

            double result = calculator.Div(50, 0);
            double result1 = calculator.Div(50, 2);

            CheckResult(result);
            CheckResult(result1);

            void CheckResult(double x)
            {
                if (x != 0)
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadLine();
        }
        static bool Handler(double x)
        {
            if (x != 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("ERROR: Cannot be divide by zero!");
                return false;
            }
        }
    }
}
