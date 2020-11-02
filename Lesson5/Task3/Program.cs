using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix myMatrix = new MyMatrix(5, 5);

            ShowArray(myMatrix);
            myMatrix.ResizeMatrix(10, 10);

            Console.WriteLine();

            ShowArray(myMatrix);

            Console.WriteLine();

            myMatrix.ShowPart(0, 1, 5, 4);

            Console.ReadLine();
        }
        static void ShowArray(MyMatrix myMatrix)
        {

            for (int i = 0; i < myMatrix.Row; i++)
            {

                for (int j = 0; j < myMatrix.Column; j++)
                {
                    Console.Write($"{myMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
