using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer(ConsoleColor.Red);
            printer.Print("What");

            PrinterA printerA = new PrinterA(ConsoleColor.Green);
            Printer printer1 = printerA;
            printer1.Print("are you");

            Printer printer2 = new PrinterB(ConsoleColor.Yellow);
            printer2.Print("gonna do?");

            if(printer1 is PrinterA printerA1)
            {
                printerA1.Print("Hah!");
            }

            Console.ReadLine();
        }
    }
}
