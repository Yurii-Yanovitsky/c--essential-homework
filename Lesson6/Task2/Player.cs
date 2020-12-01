using System;
using System.Threading;

namespace Task2
{
    public static class Player
    {
        public static void Play(Note [] notes)
        {

            foreach (Note note in notes)
            {
                if (note.IsPause)
                {
                    Thread.Sleep(500);
                }
                else
                {
                    Console.Beep(note.Freqency, note.Duration);
                }
            }
        }
    }
}
