using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating figures\n");
            Point A = new Point(1, 2, "A");
            Point B = new Point(4, 8, "B");
            Point C = new Point(6, 5, "C");
            Point D = new Point(4, 4, "D");
            Point E = new Point(3, 1, "E");

            Figure figure1 = new Figure(A, B, C, "Triangle");
            figure1.Show();
            Figure figure2 = new Figure(A, B, C, D, "Quadrangle");
            figure2.Show();
            Figure figure3 = new Figure(A, B, C, D, E, "Pentagon");
            figure3.Show();

            Console.ReadLine();
        }
    }
}
