namespace WestCoastEducation;

public class Person
{
public string FirstName {get; set; }
public string LastName {get; set; }
public string Phone {get; set; }
public string PersonalNumber {get; set; }
public string Address {get; set; }
public string PostalCode {get; set; }
public string City {get; set; }

public Person(
    string firstName,
    string lastName,
    string phone,
    string personalNumber,
    string address,
    string postalCode,
    string city)

    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        PersonalNumber = personalNumber;
        Address = address;
        PostalCode = postalCode;
        City = city;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Phone}, {City}";
    }
}
