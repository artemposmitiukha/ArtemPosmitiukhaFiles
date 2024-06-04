namespace Homework_15_2;

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Course { get; set; }

    public Student(string name, int grade, string course)
    {
        Name = name;
        Grade = grade;
        Course = course;
    }
}