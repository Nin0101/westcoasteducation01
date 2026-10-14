namespace WestCoastEducation;

public class School
{

public List <Course> Courses { get; } = new List<Course>();
public List <Student> Students { get; } = new List<Student>();
public List <Teacher> Teachers { get; } = new List<Teacher>();
public List <EducationLeader> educationLeaders { get; } = new List<EducationLeader>();
public List <Administrator> administrators { get; } = new List<Administrator>();

public bool AddCourse (Course course)
    {
        foreach (Course c in Courses)
        {
            if (c.CourseNumber ==  course.CourseNumber)
            {
                return false;
            }
        }

        Courses.Add(course);
    return true;
    }

    public void ListCourses()
    {
        if ( Courses.Count == 0)
        {
            Console.WriteLine("Inga kurser registrerade!");
            return;
        }

        foreach (Course c in Courses)
        {
            Console.WriteLine(c);
        }
    }
}
