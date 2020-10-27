using System;

namespace Task2
{
    public abstract class AbstractHandler
    {
        private string _fileName;

        public AbstractHandler(string fileName)
        {
            _fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine($"{_fileName} is open");
        }
        public void Creat()
        {
            Console.WriteLine($"{_fileName} is created");
        }
        public void Edit()
        {
            Console.WriteLine($"{_fileName} is edited");
        }
        public abstract void Save();
    }
}
