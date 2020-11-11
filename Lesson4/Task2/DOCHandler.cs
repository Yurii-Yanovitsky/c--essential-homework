using System;

namespace Task2
{
    public class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName) : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Saved like a DOC");
        }
    }
}
