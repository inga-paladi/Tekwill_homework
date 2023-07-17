using System;

namespace Module_3_Task_1
{
    public class Employee
    {
        private string name;
        private double salary;
        private string department;

        public Employee(string name, double salary, string department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Nume: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Departament:" + department);
        }
    }
}
