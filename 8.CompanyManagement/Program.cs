using _8.CompanyManagement;

List<Employee> employees = new List<Employee>();
employees.Add(new Administrator("Gosho", 1000));
employees.Add(new Salesman("Pesho", 800, 300));
employees.Add(new Worker("Ivan", 100, 8));

foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

Company company = new Company("Test");
company.Employees = employees;

Console.WriteLine(company);