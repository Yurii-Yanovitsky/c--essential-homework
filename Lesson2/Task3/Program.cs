using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position("Manager", 4400, 3);
            Employee manager = new Employee("Jhon", "Karter", position, 5);
            ShowEmployeeInfo(manager);

            Console.ReadKey();
        }
        static void ShowEmployeeInfo(Employee emp)
        {
            FinancialCalculator calculator = new FinancialCalculator(0.18m, 0.1m);
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"LastName: {emp.LastName}");
            Console.WriteLine($"Position: {emp.Position.Name}");
            Console.WriteLine($"Salary: {calculator.CalculateSalary(emp)}");
            Console.WriteLine($"Tax: {calculator.CalculateTax(emp)}");
        }
    }
}
