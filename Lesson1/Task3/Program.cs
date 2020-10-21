using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creat a book");
            Console.WriteLine("Input: title, author, content");
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            string content = Console.ReadLine();
            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadKey();
        }
    }
}
