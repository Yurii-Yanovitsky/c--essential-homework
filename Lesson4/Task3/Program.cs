using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("***Player***");
            IPlayable player1 = player;
            player1.Play();
            player1.Pause();
            player1.Stop();

            Console.WriteLine();

            Console.WriteLine("***Recorder***");
            IRecordable recorder = player;
            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            Console.ReadKey();
        }
    }
}
