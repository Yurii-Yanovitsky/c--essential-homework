using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            var workers = CreatListOfWorkers();

            Console.WriteLine("СПИСОК СОТРУДНИКОВ");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            Console.WriteLine("Введите необходимый стаж работы: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            workers = workers.Where((x) => x.Experience > experience).ToArray();

            foreach (var worker in workers)
            {
                Console.WriteLine($"Фамилия: {worker.Name}, Стаж:{worker.Experience}");
            }


            Console.ReadLine();
        }

        static Worker[] CreatListOfWorkers()
        {
            Worker[] workers = new Worker[5];

            string secondName;
            string pos;
            int year;

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Введите фамилию: ");
                secondName = Console.ReadLine();

                Console.WriteLine("Введите должность: ");
                pos = Console.ReadLine();

                while(true)
                {
                    try
                    {
                        Console.WriteLine("Введите год приема на работу: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Используйте числа!");
                    }
                }

                workers[i] = new Worker(secondName, pos, year);

                Console.Clear();
            }

            workers = workers.OrderBy((x) => x.Name).ToArray();

            return workers;
        }
    }
}
