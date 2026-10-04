namespace WestCoastEducation;

public class Administrator : EducationLeader

{
    public Administrator(string firstName, string lastName, string phone, string personalNumber, string address, string postalCode, string city, string knowledgeArea, DateTime hireDate)
    
    : base(firstName, lastName, phone, personalNumber, address, postalCode, city, knowledgeArea, hireDate)
    {
    }

    public override string ToString()
    {
        return $"Administrator: {base.ToString()}";
    }
}
