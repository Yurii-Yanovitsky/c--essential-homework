namespace Task3
{
    public class Position
    {
        public string Name { get; }
        public double InitialSalary { get; }
        public double SalaryKoef { get; }

        public Position(string name, double salary, double salaryKoef)
        {
            Name = name;
            InitialSalary = salary;
            SalaryKoef = salaryKoef;
        }
    }
}
