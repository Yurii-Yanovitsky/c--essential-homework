namespace AdditionalTask
{
    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Subtract(dynamic a, dynamic b)
        {
            return a - b;
        }
        public dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            if(b != 0)
            {
                return a / b;
            }
            else
            {
                return "Cannot be divided by zero!";
            }

        }
    }
}
