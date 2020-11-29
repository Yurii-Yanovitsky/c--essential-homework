using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double a = 0;
            double b = 0;
            bool isValid = true;

            try
            {
                Console.Write("Введите a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Введите b: ");
                b = double.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isValid = false;
            }


            if (isValid)
            {
                Console.Write("Выберете дейстиве ( +, - , * , / ): ");
                string op = Console.ReadLine();

                double? result = null;

                switch (op)
                {
                    case "+":
                        result = calculator.Add(a, b);
                        break;
                    case "-":
                        result = calculator.Subtract(a, b);
                        break;
                    case "*":
                        result = calculator.Mul(a, b);
                        break;
                    case "/":
                        result = calculator.Divide(a, b);
                        break;
                    default:
                        Console.WriteLine("Вы ввели недопустимый оператор!");
                        break;
                }

                if (result != null)
                {
                    Console.WriteLine($"{a} {op} {b} = {result}");
                }

            }

            Console.ReadLine();
        }

    }
}
