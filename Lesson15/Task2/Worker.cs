using System;

namespace Task2
{
    struct Worker
    {
        private int _year;
        public Worker(string name, string pos, int year)
        {
            _year = DateTime.Now.Year;
            Position = pos;
            Name = name;
            Year = year;
        }

        public string Name { get; }
        public string Position { get; }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 40)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Некорректно задан год! Введите еще раз:");
                    Year = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int Experience
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }

        public override string ToString()
        {
            return $"Фамилия: {Name}, Должность: {Position}, Год: {Year}";
        }
    }
}
