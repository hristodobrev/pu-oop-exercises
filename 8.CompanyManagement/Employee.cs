namespace _8.CompanyManagement
{
    public abstract class Employee
    {
        private decimal salary;
        protected Employee(string name)
        {
            this.Name = name;
        }
        protected Employee(string name, decimal salary) : this(name)
        {
            this.Salary = salary;
        }

        public string Name { get; set; }
        public virtual decimal Salary
        {
            get => this.salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Name} - ${this.Salary}";
        }
    }
}
