namespace ConsoleApp3;

public class Student
{
    public string name { get; set; }
    public List<int> grades { get; set; }

    public Student(string name, List<int> grades)
    {
        this.name = name;
        this.grades = grades;
    }
    
    public void show_student_information()
    {
        Console.WriteLine($"ФИО: {this.name}\nОценки: {string.Join(", ", this.grades)}");
    }

    public float SredOcenka()
    {
        if (this.grades.Count > 0)
        { 
            return this.grades.Sum() / this.grades.Count;
        }
        else
        {
            return 0;
        }
    }
}

