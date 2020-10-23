using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public void ConvertFromUah(double uahSum, string currencyName)
        //{
        //    switch (currencyName)
        //    {
        //        case "usd":
        //            Console.WriteLine($"{ uahSum / _usd} USD");
        //            break;
        //        case "eur":
        //            Console.WriteLine($"{ uahSum / _eur} EUR");
        //            break;
        //        case "rub":
        //            Console.WriteLine($"{ uahSum / _rub} RUB");
        //            break;
        //        default:
        //            Console.WriteLine("Incorrect data!");
        //            break;
        //    }
        //}
        //public void ConvertToUah(double currencySum, string currencyName)
        //{
        //    switch (currencyName)
        //    {
        //        case "usd":
        //            Console.WriteLine($"{ currencySum * _usd} UAH");
        //            break;
        //        case "eur":
        //            Console.WriteLine($"{ currencySum * _eur} UAH");
        //            break;
        //        case "rub":
        //            Console.WriteLine($"{ currencySum * _rub} UAH");
        //            break;
        //        default:
        //            Console.WriteLine("Incorrect data!");
        //            break;
        //    }
        //}
    }
}
