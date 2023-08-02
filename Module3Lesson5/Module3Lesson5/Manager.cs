using Module3Lesson5;
class Manager : Employee
{
    public override decimal CalculateSalary()
    {
        decimal minSalary= base.CalculateSalary();
        decimal salary = minSalary = 0.3m * minSalary * LengthOfServive;
        return salary;
    }
}