using System;
using System.Collections;

namespace AdditionalTask
{
    static class ExtensionClass
    {
        public static IEnumerable GetEven(this int[] numbers, Func<int, bool> action)
        {
            foreach (var n in numbers)
            {
                if (action(n))
                {
                    yield return n;
                }
            }
        }
    }
}
