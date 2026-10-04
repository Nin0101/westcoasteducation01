namespace WestCoastEducation;

public class Teacher : Person
{
    public string KnowledgeArea { get; set; }
    public List <Course> Courses { get; } = new List<Course>();

    public Teacher(string firstName, string lastName, string phone, string personalNumber, string address, string postalCode, string city, string knowledgeArea) 
    
    : base(firstName, lastName, phone, personalNumber, address, postalCode, city)
    {
        KnowledgeArea = knowledgeArea;
    }

    public bool AddCourse(Course course)
    {
        foreach (Course c in Courses)
        {
            if (c.CourseNumber == course.CourseNumber)
            {
                return false;
            }
        }
        Courses.Add(course);
        return true;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Kunskapsområde: {KnowledgeArea}, Antal kurser: {Courses.Count}";
    }
}
