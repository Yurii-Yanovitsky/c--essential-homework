
namespace AdditionalTask
{
    public class DivideResult
    {
        public double Value { get; }
        public string Error { get; }
        public bool IsZero { get; }

        public DivideResult(double result, string error, bool isZero)
        {
            if (isZero)
            {
                Error = error;
            }
            else
            {
                Value = result;
            }
            IsZero = isZero;
        }

        public static DivideResult GetResult(double result)
        {
            return new DivideResult(result, null, false);
        }
        public static DivideResult DivideByZero()
        {
            return new DivideResult(0, "Cannot be divided by zero!", true);
        }
    }
}
