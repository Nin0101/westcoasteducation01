namespace WestCoastEducation;

public class Course
{
public string CourseNumber { get; set; }
public string Title { get; set; }
public int Length { get; set; }
public DateTime StartDate { get; set; }
public DateTime EndDate { get; set; }
public CourseType Type { get; set; }
public Teacher? ResponsibleTeacher { get; set; }
public List <Student> Students { get; } = [];

public Course( string courseNumber, string title, int length, DateTime startDate, DateTime endDate, CourseType type)

    {
        CourseNumber = courseNumber;
        Title = title;
        Length = length;
        StartDate = startDate;
        EndDate = endDate;
        Type = type; 
    }

    public bool AddStudent(Student student)
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

    public override string ToString()
    {
        return $"{CourseNumber}: {Title}: {Length} veckor, {Type}"; 
    }

    public void ListStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("Inga studenter anmälda");
            return;
        }

        foreach (Student s in Students)
        {
            Console.WriteLine(s);
        }
    }
}