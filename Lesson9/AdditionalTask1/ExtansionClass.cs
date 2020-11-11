namespace AdditionalTask1
{
    public static class ExtansionClass
    {
        public static DynamicArrayOfInt Filter(this DynamicArrayOfInt source, FilterDelegate del)
        {
            DynamicArrayOfInt result = new DynamicArrayOfInt();
            for (int i = 0; i < source.Length; i++)
            {
                if (del(source[i]))
                {
                    result.Add(source[i]);
                }
            }
            return result;
        }
    }
}
