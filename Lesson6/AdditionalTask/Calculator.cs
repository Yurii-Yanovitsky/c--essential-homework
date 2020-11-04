using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    public static class Calculator
    {
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static DivideResult Divide(double a, double b) => b == 0 ? DivideResult.DivideByZero() : DivideResult.GetResult(a / b);

    }
}
