namespace WestCoastEducation;

public class Course
{
public string CourseNumber { get; set; }
public string Title { get; set; }
public int Length { get; set; }
public DateTime StartDate { get; set; }
public DateTime EndDate { get; set; }
public CourseType Type { get; set; }

public Course( string courseNumber, string title, int length, DateTime startDate, DateTime endDate, CourseType type)

    {
        CourseNumber = courseNumber;
        Title = title;
        Length = length;
        StartDate = startDate;
        EndDate = endDate;
        Type = type; 
    }

    public override string ToString()
    {
        return $"{CourseNumber}: {Title}: {Length} veckor, {Type}"; 
    }
}