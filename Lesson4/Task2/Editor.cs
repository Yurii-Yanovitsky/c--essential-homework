using System;

namespace Task2
{
    public class Editor
    {
        private AbstractHandler _handler;
        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);
            switch (format)
            {
                case ".doc":
                    _handler = new DOCHandler(fileName);
                    break;
                case ".txt":
                    _handler = new TXTHandler(fileName);
                    break;
                case ".xml":
                    _handler = new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("Undefiend format");
                    break;
            }
        }

        public void Open()
        {
            _handler.Open();
        }
        public void Creat()
        {
            _handler.Creat();
        }
        public void Edit()
        {
            _handler.Edit();
        }
        public void Save()
        {
            _handler.Save();
        }
    }
}
