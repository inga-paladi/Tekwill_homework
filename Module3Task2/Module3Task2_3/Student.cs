namespace Module3Task2_3
{
    public class Student
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Specialization { get; set; }

        public Student(string name, int age, string specialization)
        {
            Name = name;
            Age = age;
            Specialization = specialization;
        }

        public Student(Student otherStudent) 
        {
            Name = otherStudent.Name;
            Age = otherStudent.Age;
            Specialization = otherStudent.Specialization;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " +  Age);
            Console.WriteLine("Specialization: " +  Specialization);  
        }

        public void UpdateDetails(string name, int age, string specialization)
        {
            Name = name;
            Age = age;
            Specialization = specialization;
        }
    }
}
