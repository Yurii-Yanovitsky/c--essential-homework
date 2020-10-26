using System;

namespace Task2
{
    public abstract class Pupil
    {
        public Pupil(string name)
        {
            Name = name;
        }

        public string  Name { get; }
        public virtual void Study()
        {
            Console.WriteLine("I can study.");
        }
        public virtual void Read()
        {
            Console.WriteLine("I can read.");
        }
        public virtual void Write()
        {
            Console.WriteLine("I can write.");
        }
        public virtual void Relax()
        {
            Console.WriteLine("I can relax.");
        }
    }
}
