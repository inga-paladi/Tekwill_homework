using System;

namespace Module3Task3_1
{
    public class Manager : Employee 
    {
        protected string Department { get; set; }

        public Manager(string name, string department) : base(name) => Department = department;
        
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Department: {0}", Department);
        }
    }
}
