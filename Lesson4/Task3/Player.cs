using System;

namespace Task3
{
    public class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Music is on");
        }

        public void Record()
        {
            Console.WriteLine("Recording is on");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause music");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Pause recording");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Music is off");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recording is off");
        }
    }
}
