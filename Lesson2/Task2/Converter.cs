using System;

namespace Task2
{
    class Converter
    {
        double _usd;
        double _eur;
        double _rub;
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }
        public Converter()
        {

        }
        public void FromUsdToUah(double usdAmount)
        {
            Console.WriteLine($"{usdAmount * _usd} UAH");
        }

        public void FromUahToUsd(double uahAmount)
        {
            Console.WriteLine($"{uahAmount / _usd} USD");
        }

        public void FromEurToUah(double eurAmount)
        {
            Console.WriteLine($"{eurAmount * _eur} UAH");
        }

        public void FromUahToEur(double uahAmount)
        {
            Console.WriteLine($"{uahAmount / _eur} EUR");
        }

        public void FromRubToUah(double rubAmount)
        {
            Console.WriteLine($"{rubAmount * _rub} UAH");
        }

        public void FromUahToRub(double uahAmount)
        {
            Console.WriteLine($"{ uahAmount / _rub} RUB");
        }
    }
}
