namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Student student = new Student("Nin", "King", "07323111", "20020130031", "Storgatan 1", "32243", "Göteborg");

        Console.WriteLine(student);
    


    Course course = new Course("C001", "C# Programmering", 5, new DateTime(2026, 10, 1), new DateTime(2026, 11, 5), CourseType.Classroom);

    Console.WriteLine(course);
    }
}
