using System;

namespace AdditionalTask
{
    class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Mul(double a, double b) => a * b;
        public double? Divide(double a, double b)
        {
            try
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    throw new Exception("На нуль делить нельзя!");
                }
     
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
