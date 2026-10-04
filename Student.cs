namespace WestCoastEducation;

public class Student : Person
{
    public Student(
        string firstName,
        string lastName,
        string phone,
        string personalNumber,
        string address,
        string postalCode,
        string city)
        
        : base(firstName, lastName, phone, personalNumber, address, postalCode, city)
    {
    }
}