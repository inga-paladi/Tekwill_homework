
using Module3Task2_3;

class Program
{
    static void Main(string[] args)
    {
        Student originalStudent = new Student("John Doe", 20, "Computer Science");

        Student copiedStudent = new Student(originalStudent);

        originalStudent.UpdateDetails("Jane Smith", 21, "Software Engineering");

        Console.WriteLine("Original Student Details:");
        originalStudent.ShowDetails();

        Console.WriteLine("\nCopied Student Details:");
        copiedStudent.ShowDetails();
    }
}