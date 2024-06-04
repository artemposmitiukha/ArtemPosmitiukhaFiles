namespace Homework_15_2;

class Program
{
    static void Main(string[] args)
    {
        Student student_1 = new Student("Elora Rice", 87, "UI/UX Start");
        Student student_2 = new Student("Madeline Molina", 91, "C# Basic");
        Student student_3 = new Student("Willow Wilkins", 98, "UI/UX Start");
        Student student_4 = new Student("Prince Flores", 79, "C# Basic");
        Student student_5 = new Student("Celine Landry", 93, "UI/UX Start");
        Student student_6 = new Student("Jaxx Serrano", 56, "C# Basic");

        List<Student> studentsList = new List<Student>() { student_1, student_2, student_3, student_4, student_5, student_6 };
        var gradeCheck = studentsList.Where(grade => grade.Grade > 90);
        Console.WriteLine("Student with grade moore than 90: ");
        foreach (var student in gradeCheck)
            Console.WriteLine($"Name: {student.Name} | Grade: {student.Grade} | Course: {student.Course}");
        
        Console.WriteLine("----------------------------------");
        
        var studentSort = studentsList.OrderByDescending(student => student.Grade).ToList();
        foreach (var grade in studentSort)
            Console.WriteLine($"Name: {grade.Name} | Grade: {grade.Grade} | Course: {grade.Course}");
        
        Console.WriteLine("----------------------------------");

        var studentGroup = studentsList.GroupBy(student => student.Course);
        foreach (var group in studentGroup)
        {
            Console.WriteLine($"Students group: {group.Key}: ");
            foreach (var student in group)
                Console.WriteLine($"Name: {student.Name} | Grade: {student.Grade}");
            Console.WriteLine();
        }

        Console.WriteLine("----------------------------------");

        var studentCount = 
            studentsList.GroupBy(student => student.Course).ToDictionary(group => group.Key, group => group.Count());
        foreach (var course in studentCount)
            Console.WriteLine($"Course: {course.Key} | Count: {course.Value}");
        
        Console.WriteLine("----------------------------------");

        List<string> students = studentsList.Select(student => $"Name: {student.Name} | Grade: {student.Grade}").ToList();
        foreach (var student in students)
            Console.WriteLine(student);


    }
}