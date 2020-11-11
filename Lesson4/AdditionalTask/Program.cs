using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title("Contract");
            Body body = new Body("Document body...");
            Footer footer = new Footer("Page: 1");

            Document document = new Document(title, body, footer);
            document.Show();

            Console.WriteLine();

            Document document2 = new Document();
            document2.Title = "MyDocument";
            document2.Body = "MyDocument body...";
            document2.Footer = "Writetenn by me";

            document2.Show();

            Console.ReadLine();
        }
    }
}
