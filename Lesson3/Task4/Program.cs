using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input key (pro/exp)");
            string key = Console.ReadLine();
            DocumentWorker worker = CreatDocument(key);

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }
        static DocumentWorker CreatDocument(string key)
        {
            if (key.ToLower() == "pro")
            {
                return new ProDocumentWorker();
            }
            else if (key.ToLower() == "exp")
            {
                return new ExpertDocumentWorker();
            }
            else
            {
                return new DocumentWorker();
            }
        }
    }
}
