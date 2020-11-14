using System;
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
            var result1 = MyClass<int>.FactoryMethod();
            var result2 = MyClass<char>.FactoryMethod();
            var result3 = MyClass<int>.FactoryMethod();
            var result4 = MyClass<bool>.FactoryMethod();
            var result5 = MyClass<Program>.FactoryMethod();

            Console.WriteLine(result1.GetType().Name);
            Console.WriteLine(result2.GetType().Name);
            Console.WriteLine(result3.GetType().Name);
            Console.WriteLine(result4.GetType().Name);
            Console.WriteLine(result5.GetType().Name);

            Console.ReadLine();
        }
    }
    static class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T ();
        }
    }
}
