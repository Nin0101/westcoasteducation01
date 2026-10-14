namespace WestCoastEducation;

public class School
{

public List <Course> Courses { get; } = [];
public List <Student> Students { get; } = [];
public List <Teacher> Teachers { get; } = [];
public List <EducationLeader> EducationLeaders { get; } = [];
public List <Administrator> Administrators { get; } = [];

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

     public bool AddStudent (Student student)
    {
        foreach (Student s in Students)
        {
            if (s.PersonalNumber == student.PersonalNumber)
            {
                return false;
            }
        }
        Students.Add(student);
        return true;


    }

    public void ListStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No students registered!");
            return;
        }

        foreach (Student s in Students)
        {
            Console.WriteLine(s);
        }
    }

    public bool AddTeacher (Teacher teacher)
    {
        foreach (Teacher t in Teachers)
        {
            if (t.PersonalNumber == teacher.PersonalNumber)
            {
                return false;
            }
        }

        Teachers.Add(teacher);
        return true;
    }

    public bool AddEducationLeader (EducationLeader leader)
    {
        foreach (EducationLeader l in EducationLeaders)
        {
            if (l.PersonalNumber == leader.PersonalNumber)
            {
                return false;
            }
        }

        EducationLeaders.Add(leader);
        return true;
    }

    public bool AddAdministrator (Administrator administrator)
    {
        foreach (Administrator a in Administrators)
        {
            if (a.PersonalNumber == administrator.PersonalNumber)
            {
                return false;
            }
        }

        Administrators.Add(administrator);
        return true;
    }

}
