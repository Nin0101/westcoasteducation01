namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Student student = new("Lars", "Lennart", "0734324351", "200204321423", "Storgatan 1", "32243", "Göteborg");

        Console.WriteLine(student);

        Teacher teacher = new("Sova", "Louse", "0791323122", "199703157161", "Strömgatan 3", "34232", "Göteborg", "Webbutveckling");

        Course course = new("C001", "C# Programmering", 5, new DateTime(2026, 10, 1), new DateTime(2026, 11, 5), CourseType.Classroom);

        EducationLeader leader = new("Bo", "Karlsson", "0709876543", "197305058971", "Västragatan 3", "41102", "Göteborg", "Mobilutveckling", new DateTime(2020, 1, 15));

        Administrator admin = new("Andrea", "Meia", "0705554433", "199009094323", "Amiralsgatan 4", "41103", "Göteborg", "IT-drift", new DateTime(2018, 3, 1));

        teacher.AddCourse(course);
        teacher.AddCourse(course);

        Console.WriteLine(course.AddStudent(student));

        Console.WriteLine(course.AddStudent(student));

        course.ListStudents();

        Console.WriteLine(teacher);
    
        Console.WriteLine(course);

        Console.WriteLine(leader);

        Console.WriteLine(admin);
    }

    

}
