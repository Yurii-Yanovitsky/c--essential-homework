namespace AdditionalTask2
{
    public static class ExtansionClass
    {
        public static void ForEach(this DynamicArrayOfInt source, IntAction del)
        {
            for (int i = 0; i < source.Length; i++)
            {
                del(source[i]);
            }
        }
    }
}
