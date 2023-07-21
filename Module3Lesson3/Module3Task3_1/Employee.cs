namespace Module3Task3_1
{
    public class Employee
    {
        protected string Name { get; set; }

        public Employee(string name) => Name = name;

        public virtual void ShowDetails() => Console.WriteLine("Name:{0}", Name);
        
    }
}
