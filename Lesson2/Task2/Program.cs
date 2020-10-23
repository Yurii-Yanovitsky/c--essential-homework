using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting currencies: ");

            double usd = 28.26;
            double eur = 33.55;
            double rub = 0.37;
            Converter converter = new Converter(usd, eur, rub);

            converter.FromUahToEur(100);
            converter.FromUahToUsd(200);
            converter.FromRubToUah(80);
            converter.FromUsdToUah(150);

            Console.ReadKey();
        }
    }
}
