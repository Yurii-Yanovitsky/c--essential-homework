using System;

namespace AdditionalTask2
{
    public static class TextFinder
    {
        static public string[] FindAllOccurances(string subtext, string text, int n)
        {
            string[] strArray = text.Split(new char[1] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] result = new string[CountAllOccurances()];
            int index = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                if (n % 2 == 0)
                {
                    Console.Write("The number of context lines must be odd!");
                    break;
                }

                else if (strArray[i].Contains(subtext) && i - n / 2 >= 0 && i + n / 2 < strArray.Length)
                {
                    result[index] = "";

                    for (int j = i - n / 2; j <= i + n / 2; j++)
                    {
                        result[index] += strArray[j];
                    }

                    index++;
                }

                else if (strArray[i].Contains(subtext))
                {
                    result[index] = strArray[i];
                    index++;
                }
            }

            int CountAllOccurances()
            {
                int count = 0;

                for (int j = 0; j < strArray.Length; j++)
                {
                    if (strArray[j].Contains(subtext))
                    {
                        count++;
                    }
                }

                return count;
            }

            return result;
        }
    }
}
