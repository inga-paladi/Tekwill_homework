namespace Module3Lesson5
{
    public class Employee
    {
        public string Name { get; set; }
        public int LengthOfServive { get; set; }
        public virtual decimal CalculateSalary()
        {
            return 10000;
        }

    }
}
