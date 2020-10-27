using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor.ChooseDocument("MyDocument.doc");
            editor.Open();
            editor.Edit();
            editor.Save();

            editor.ChooseDocument(".txt");
            editor.Creat();

            Console.ReadKey();
        }
    }
}
