using System;
using Task2_Library;

namespace Task2
{

    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Method1();
              
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.CallMethod2();

            Console.ReadLine();
        }
    }
    public class DerivedClass : MyClass
    {
        public void CallMethod2()
        {
            Method2();
        }
    }

}
