namespace _8.CompanyManagement
{
    public class Worker : Employee
    {
        public Worker(string name, decimal rate, int workingHours) : base(name)
        {
            this.Rate = rate;
            this.WorkingHours = workingHours;
        }

        public int WorkingHours { get; set; }
        public decimal Rate { get; set; }

        public override decimal Salary { get => this.Rate * this.WorkingHours; }
    }
}
