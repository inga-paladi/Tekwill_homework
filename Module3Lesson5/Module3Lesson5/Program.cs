using Module3Lesson5;
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Manager { Name = "Manager", LengthOfServive = 5 });
        employees.Add(new Programmer { Name = "Programmer", LengthOfServive = 3, KnownLanguages = new List<string> { "C#", "Java" } });
        employees.Add(new Accountant { Name = "Accountant", LengthOfServive = 7 });
        
        foreach(Employee employee in employees)
        {
            decimal salary = employee.CalculateSalary();
            Console.WriteLine($"{employee.Name}: {salary}");
        }
    }
    
}