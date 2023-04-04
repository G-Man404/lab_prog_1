using ConsoleApp3;

class Program
{
    static void Main()
    {
        Student student = new Student("Иванов", new List<int>{3, 5});
        student.show_student_information();
        Console.WriteLine(student.SredOcenka());
    }
}