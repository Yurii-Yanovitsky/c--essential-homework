using System;
using System.Threading;

namespace Task2
{
    class Matrix
    {
        private static readonly object locker = new object();
        private readonly int colunm;
        private const string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private static Random random;
        public bool NeedSecond { get; set; }

        public Matrix(int col, bool needSecond)
        {
            colunm = col;
            NeedSecond = needSecond;
            random = new Random((int)DateTime.Now.Ticks);
        }

        public void Move()
        {
            int count;
            int length;

            while (true)
            {
                count = random.Next(3,10);
                length = 0;
                Thread.Sleep(random.Next(20, 5000));

                for (int i = 0; i < 40; i++)
                {
                    Thread.Sleep(random.Next(100));
                    lock (locker)
                    {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;

                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = colunm;
                            Console.WriteLine(" ");
                        }
                        if (length < count)
                        {
                            length++;
                        }
                        else if (length == count)
                        {
                            count = 0;
                        }

                        if (NeedSecond && i >= length && (random.Next(1, 5) == 3))
                        {
                            Thread thread = new Thread(new Matrix(colunm + 1, false).Move);
                            thread.Start();
                            NeedSecond = false;
                        }
                        if (39 - i < length)
                        {
                            length--;
                        }

                        Console.CursorTop = i - length + 1;

                        for (int j = length - 1; j >= 0; j--)
                        {
                            if (j == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.CursorLeft = colunm;
                                Console.WriteLine(GetChar());
                            }
                            else if (j == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.CursorLeft = colunm;
                                Console.WriteLine(GetChar());
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.CursorLeft = colunm;
                                Console.WriteLine(GetChar());
                            }
                        }
                    }
                }
            }
        }
        private char GetChar()
        {
            int index = random.Next(62);
            return symbols.ToCharArray()[index];
        }
    }
}
