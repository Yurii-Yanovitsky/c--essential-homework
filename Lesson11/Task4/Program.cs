using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList notGenericList = new ArrayList(10);

            notGenericList.Add("Hello!");
            notGenericList.Add('A');
            notGenericList.Add(5);
            notGenericList.Add(24.5);
            notGenericList.Add(true);

            foreach (var item in notGenericList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
