using System;

namespace Task2
{
    public class Editor
    {
        public Editor(string fileName)
        {
            ChooseDocument(fileName);
        }

        public AbstractHandler Handler { get; private set; }
        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);
            switch (format)
            {
                case ".doc":
                    Handler = new DOCHandler(fileName);
                    break;
                case ".txt":
                    Handler = new TXTHandler(fileName);
                    break;
                case ".xml":
                    Handler = new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("Undefiend format");
                    break;
            }
        }

        public void Open()
        {
            Handler.Open();
        }
        public void Creat()
        {
            Handler.Creat();
        }
        public void Edit()
        {
            Handler.Edit();
        }
        public void Save()
        {
            Handler.Save();
        }
    }
}
