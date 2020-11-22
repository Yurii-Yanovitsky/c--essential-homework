namespace Task4
{
    class Model
    {
        public string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        public string Subtract(int a, int b)
        {
            return (a - b).ToString();
        }

        public string Mul(int a, int b)
        {
            return (a * b).ToString();
        }
        public string Divide(int a, int b)
        {
            string result = b == 0 ? "ERROR" : ((double)a / b).ToString();
            return result;
        }
    }
}
