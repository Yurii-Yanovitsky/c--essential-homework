namespace AdditionalTask4
{
    public class Calculator
    {
        DivideByZeroErrorHandler ErrorHandler;

        public Calculator(DivideByZeroErrorHandler handler)
        {
            ErrorHandler = handler;
        }
        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => a - b;
        public double Mul(double a, double b) => a * b;
        public double Div(double a, double b) => ErrorHandler(b) ? a / b : 0;
    }
}
