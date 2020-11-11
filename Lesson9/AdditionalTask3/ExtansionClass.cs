namespace AdditionalTask3
{
    public static class ExtansionClass
    {
        public static double Accumulate(this DynamicArrayOfInt list, BinaryExpression accumulator)
        {
            double sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = accumulator(sum, list[i]);
            }
            return sum;
        }
    }
}
