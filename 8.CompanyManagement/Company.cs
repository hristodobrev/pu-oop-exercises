namespace _8.CompanyManagement
{
    public class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal SalaryCosts { get => this.Employees.Select(e => e.Salary).Sum(); }

        public Company(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name} - Expenses: ${this.SalaryCosts}";
        }
    }
}
