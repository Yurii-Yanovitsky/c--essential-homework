using System;

namespace Task2
{
    public class Note
    {
        public int Freqency { get; }
        public int Duration { get; }
        public bool IsPause { get; }

        public Note(int freqency, int duration)
        {
            Freqency = freqency;
            Duration = duration;
        }

        public Note(bool isPause)
        {
            IsPause = isPause;
        }

        public static Note CreatDo(int octave, int duration)
        {
            int frequency = 262 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
        public static Note CreatRe(int octave, int duration)
        {
            int frequency = 294 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
        public static Note CreatMi(int octave, int duration)
        {
            int frequency = 330 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
        public static Note CreatFa(int octave, int duration)
        {
            int frequency = 349 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
        public static Note CreatSol(int octave, int duration)
        {
            int frequency = 392 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
        public static Note CreatLya(int octave, int duration)
        {
            int frequency = 440 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
        public static Note CreatSi(int octave, int duration)
        {
            int frequency = 494 * (int)Math.Pow(2, octave - 1);
            return new Note(frequency, duration);
        }
    }
}
