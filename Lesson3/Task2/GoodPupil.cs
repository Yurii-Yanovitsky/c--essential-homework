using System;

namespace Task2
{
    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {

        }

        public override void Study()
        {
            Console.WriteLine("I study 5 days a week.");
        }
        public override void Read()
        {
            Console.WriteLine("I read enough.");
        }
        public override void Write()
        {
            Console.WriteLine("I write enough");
        }
        public override void Relax()
        {
            Console.WriteLine("I have a rest 2 days a week.");
        }
    }
}
