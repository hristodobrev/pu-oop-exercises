namespace _8.CompanyManagement
{
    public class Salesman : Employee
    {
        public Salesman(string name, decimal salary, decimal commission) : base(name, salary)
        {
            this.Commission = commission;
        }

        public decimal Commission { get; set; }

        public override decimal Salary
        {
            get
            {
                return base.Salary + this.Commission;
            }
        }
    }
}
