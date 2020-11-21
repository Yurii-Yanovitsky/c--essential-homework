using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("не изменено");
            MyStruct myStruct = new MyStruct("не изменено");

            Console.WriteLine("До вызова методов:");
            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine();

            Console.WriteLine("После вызова методов:");
            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);

            Console.WriteLine();

            Console.WriteLine(@"Экзепляр структуры передается в метод по
значению, а экземпляр класса - по ссылке!");

            Console.ReadLine();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change = "изменено";
        }
    }
}
