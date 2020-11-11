using System;

namespace Task2
{
    public class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {

        }

        public override void Study()
        {
            Console.WriteLine("I study 2 days a week.");
        }
        public override void Read()
        {
            Console.WriteLine("I read little.");
        }
        public override void Write()
        {
            Console.WriteLine("I write little");
        }
        public override void Relax()
        {
            Console.WriteLine("I have a rest 5 days a week.");
        }
    }
}
