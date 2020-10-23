namespace Task3
{
    public class Position
    {
        public string Name { get; }
        public decimal InitialSalary { get; }
        public decimal SalaryKoef { get; }

        public Position(string name, decimal salary, decimal salaryKoef)
        {
            Name = name;
            InitialSalary = salary;
            SalaryKoef = salaryKoef;
        }
    }
}
