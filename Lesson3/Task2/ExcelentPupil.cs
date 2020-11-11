using System;

namespace Task2
{
    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) :base(name)
        {

        }
        public override void Study()
        {
            Console.WriteLine("I study everyday.");
        }
        public override void Read()
        {
            Console.WriteLine("I read a lot of books.");
        }
        public override void Write()
        {
            Console.WriteLine("I write a lot.");
        }
        public override void Relax()
        {
            Console.WriteLine("I hardly rest.");
        }
    }
}
