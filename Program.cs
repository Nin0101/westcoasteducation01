namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Student student = new Student("Nin", "King", "07323111", "20020130031", "Storgatan 1", "32243", "Göteborg");

        Console.WriteLine(student);

        Teacher teacher = new Teacher ("Sova", "Louse", "079132312", "19181811", "Strömgatan 1", "34232", "Trelleborg", "Webbutveckling");

        Course course = new Course("C001", "C# Programmering", 5, new DateTime(2026, 10, 1), new DateTime(2026, 11, 5), CourseType.Classroom);


        teacher.AddCourse(course);
        teacher.AddCourse(course);

        Console.WriteLine(teacher);
    

    Console.WriteLine(course);
    }

    

}
