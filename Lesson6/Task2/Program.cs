using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string melody = "987 876 765 654 543 432 111 8";
            Note[] notes = MelodyParser.ParseMelody(melody);
            Player.Play(notes);

            Console.ReadLine();
        }
    }
}