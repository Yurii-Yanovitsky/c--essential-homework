using System;

namespace AdditionalTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1, 5));
            Console.WriteLine(Calculator.Subtract(3, 4));
            Console.WriteLine(Calculator.Multiply(0, 1));

            CheckDivisionResult(Calculator.Divide(25, 0));
            CheckDivisionResult(Calculator.Divide(25, 5));

            void CheckDivisionResult(DivideResult result)
            {
                if (!result.IsZero)
                {
                    Console.WriteLine(result.Value);
                }
                else
                {
                    Console.WriteLine("ERROR: " + $"{result.Error}");
                }
            }

            Console.ReadLine();
        }
    }
}
