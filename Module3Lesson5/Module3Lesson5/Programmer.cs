using Module3Lesson5;
public class Programmer : Employee 
{
    public List<string> KnownLanguages { get; set; }
    
    public override decimal CalculateSalary()
    {
        decimal minSalary = base.CalculateSalary();  
        decimal salary = minSalary;
        
        foreach (string language in KnownLanguages)
        {
            if (language == "C#")
            {
                salary += 4 * minSalary;
            }
            else
            {
                salary += 0.5m * minSalary;
            }
        }
        
        return salary;
    }
}

