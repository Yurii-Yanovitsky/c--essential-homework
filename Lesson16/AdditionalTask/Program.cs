using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20, 30);
            Point p2 = new Point(30, 10, 20);

            Console.WriteLine($"p1 - {p1}");
            Console.WriteLine($"p2 - {p2}");

            Point p3 = p1 + p2;

            Console.WriteLine($"p3 - {p3}");

            Console.ReadLine();
        }
    }

    struct Point
    {
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public static Point operator +(Point p1, Point p2)
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;
            int z = p1.Z + p2.Z;
            return new Point(x, y, z);
        }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}, z = {Z}";
        }
    }
}
