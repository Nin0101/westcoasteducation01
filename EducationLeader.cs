using System.Dynamic;

namespace WestCoastEducation;

public class EducationLeader : Teacher

{
   
    public DateTime HireDate { get; set; }
    public EducationLeader(string firstName, string lastName, string phone, string personalNumber, string address, string postalCode, string city, string knowledgeArea, DateTime hireDate) 
    
    : base(firstName, lastName, phone, personalNumber, address, postalCode, city, knowledgeArea)
    {
        HireDate = hireDate;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Anställd: {HireDate:yyyy-MM-dd}";
    }
}
