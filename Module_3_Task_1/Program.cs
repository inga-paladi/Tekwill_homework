using System;

namespace Module_3_Task_1
{
    public static class MainClass
    {
        public static void Main()
        {
            Employee employee1 = new Employee("John", 1500, "QA");
            Employee employee2 = new Employee("Alice", 2000, "Development");
            Employee employee3 = new Employee("Bob", 1800, "HR");

            employee1.ShowDetails();
            employee2.ShowDetails();
            employee3.ShowDetails();
        }
    }
}
