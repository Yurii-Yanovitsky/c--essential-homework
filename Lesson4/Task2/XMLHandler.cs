using System;

namespace Task2
{
    public class XMLHandler: AbstractHandler
    {
        public XMLHandler(string fileName):base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Saved like a DOC");
        }
    }
}
