using System;

namespace Task3
{
    public delegate int MyDelegate();
    public delegate double Del(MyDelegate[] delegates);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of methods: ");
            int n = int.Parse(Console.ReadLine());

            MyDelegate[] delegates = new MyDelegate[n];
            Random random = new Random();

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => random.Next(100);
            }

            Del del = delegate (MyDelegate[] d)
            {
                int sum = 0;
                int num = 0;
                for (int i = 0; i < d.Length; i++)
                {
                    num = d[i].Invoke();
                    sum += num;
                    Console.WriteLine(num);
                }
                return sum / (double)d.Length;
            };

            double average = del(delegates);

            Console.WriteLine($"Average: {average}");

            Console.ReadLine();
        }
    }
}
