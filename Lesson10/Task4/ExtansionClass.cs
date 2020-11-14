namespace Task4
{
    public static class ExtansionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] newArray = new T[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                newArray[i] = list[i];
            }

            return newArray;
        }
    }
}
