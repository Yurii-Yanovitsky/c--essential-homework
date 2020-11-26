using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public static class ExtensionClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int index = 0;

            T[] newArray = new T[list.Count()];

            foreach (var item in list)
            {
                newArray[index] = item;
                index++;
            }

            return newArray;
        }
    }
}
