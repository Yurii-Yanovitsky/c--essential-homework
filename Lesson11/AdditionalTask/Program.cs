using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(10);

            arrayList.Add("Hello!");
            arrayList.Add('A');
            arrayList.Add(5);
            arrayList.Add(24.5);
            arrayList.Add(true);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            //ВЫВОД: Типы значений автоматически упаковываются в Object при передаче их методу Add().

            Console.ReadLine();
        }
    }
}
