using System;

namespace Task2
{
    public class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName) : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Saved like a TXT");
        }
    }
}
