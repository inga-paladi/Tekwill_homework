using Module3Lesson5;
public class Accountant : Employee 
{
    public override decimal CalculateSalary()
    {
        decimal minSalary = base.CalculateSalary();
        decimal salary = minSalary + 0.2m * minSalary * LengthOfServive;
        return salary;  
    }
}

